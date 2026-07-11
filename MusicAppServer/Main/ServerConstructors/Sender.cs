using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Music_App.Client_class;
using MusicAppServer.Controllers;
using MusicAppServer.Data;
using MusicAppServer.Exceptions;
using MusicAppServer.Models;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace MusicAppServer.Main.ServerConstructors;

/// <summary>
/// Provides functionality to stream audio files to connected TCP clients.
/// </summary>
public static class Sender
{
    private static readonly PasswordHasher<string> _hasher = new PasswordHasher<string>();

    /// <summary>
    /// Asynchronously streams a specific audio file to the connected <see cref="TcpClient"/>.
    /// </summary>
    /// <param name="client">The active TCP client connection.</param>
    /// <returns>A task that represents the asynchronous streaming operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> is null.</exception>
    /// <exception cref="FileNotFoundExceptionEx">Thrown when the requested audio file does not exist on disk.</exception>
    /// <exception cref="PlaybackException">Thrown when a network streaming error occurs during playback transmission.</exception>
    public static async Task SendSongAsync(TcpClient client, string filePath)
    {
        if (client == null)
        {
            using (client)
            using (NetworkStream networkStream = client.GetStream())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(nameof(client));
                await networkStream.WriteAsync(buffer, 0, buffer.Length);
                throw new ArgumentNullException(nameof(client));
            }
        }

        if (!File.Exists(filePath))
        {
            client.Close();
            throw new FileNotFoundExceptionEx();
        }

        try
        {
            // Using declaration ensures streams are disposed of immediately after the scope ends
            using (client)
            using (NetworkStream networkStream = client.GetStream())
            using (FileStream fileStream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[32768]; // 32 KB buffer size
                int bytesRead;

                // Read chunks asynchronously from disk and stream them directly onto the network
                while ((bytesRead = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await networkStream.WriteAsync(buffer, 0, bytesRead);
                }
            }

            Console.WriteLine(Globals.MsgSongSent);
        }
        catch (Exception ex)
        {
            // Wrap underlying socket errors into our domain custom exception
            throw new PlaybackException();
        }
    }

    /// <summary>
    /// Asynchronously processes a user sign-up request by verifying email uniqueness, 
    /// creating a new user account if available, and transmitting the response status to the client.
    /// </summary>
    /// <param name="client">The active TCP client connection.</param>
    /// <param name="login">The email address submitted by the client as their unique identifier.</param>
    /// <param name="password">The securely hashed password for the new account.</param>
    /// <param name="name">The display name or username for the new account.</param>
    /// <returns>A task that represents the asynchronous verification, database persistence, and response operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/>, <paramref name="login"/>, <paramref name="password"/>, or <paramref name="name"/> is null.</exception>
    /// <exception cref="DatabaseException">Thrown when a database or network communication failure occurs during execution.</exception>
    public static async Task IsSignUpAsync(TcpClient client, string login, string password, string name)
    {
        if (client == null)
            throw new ArgumentNullException(nameof(client));

        if (login == null)
            throw new ArgumentNullException(nameof(login));

        if (password == null)
            throw new ArgumentNullException(nameof(password));

        if (name == null)
            throw new ArgumentNullException(nameof(name));

        try
        {
            bool canSign;

            // Step 1: Check if the user email is already taken
            using (var context = new AppDBContext())
            {
                var userController = new UserController(context);
                // If user does NOT exist, email is available (canSign = true)
                canSign = !await userController.IsUserExistsByEmailAsync(login);
            }

            if (!canSign)
            {
                throw new AuthenticationException("The provided email is already registered. Please use a different email address.");
            }
            // Step 2: Choose the response buffer based on existence check
            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new MessageRequestModel() { 
                    IsSuccess = true,
                    MessageContent = Globals.MsgApproveClientRequest
                }));

            // Step 3: If email is clear, save the new user record into the database

            string hashedPassword = _hasher.HashPassword(login, password);

            using (var context = new AppDBContext())
            {
                var uc = new UserController(context);
                var u = new User()
                {
                    Name = name,
                    Email = login,
                    Password = hashedPassword
                };
                await uc.AddUserAsync(u);
            }
            

            // Step 4: Safely transmit the final feedback to the client application
            // It will be disposed at the end of the block, but client remains alive.
            using (NetworkStream networkStream = new NetworkStream(client.Client, ownsSocket: false))
            {
                await networkStream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        catch (AuthenticationException authEx)
        {
            throw authEx;
        }
        catch (MusicServiceException)
        {
            // Re-throw our custom handled domain exceptions directly
            throw;
        }
        catch (Exception ex)
        {
            // Wrap any unexpected database/network framework crashes into a safe DatabaseException
            throw new DatabaseException("An unexpected error occurred during sign-up processing or transmission.", ex);
        }
    }

    /// <summary>
    /// Asynchronously processes a user log-in request by verifying the provided credentials and sending the appropriate encoded global response message to the client.
    /// </summary>
    /// <param name="client">The active TCP client connection.</param>
    /// <param name="login">The email address or login identifier submitted by the client.</param>
    /// <param name="password">The password associated with the account.</param>
    /// <returns>A task that represents the asynchronous verification and response operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/>, <paramref name="login"/>, or <paramref name="password"/> is null.</exception>
    /// <exception cref="DatabaseException">Thrown when the database queries fail during credential validation.</exception>
    public static async Task IsLogInAsync(TcpClient client, string login, string password)
    {
        if (client == null)
            throw new ArgumentNullException(nameof(client));

        if (login == null)
            throw new ArgumentNullException(nameof(login));

        if (password == null)
            throw new ArgumentNullException(nameof(password));

        try
        {

            // Context is disposed immediately after fetching data
            using (var context = new AppDBContext())
            {
                var userController = new UserController(context);
                // Straightforward logic: if credentials match — true, otherwise — false
                var dbUser = await userController.GetUserByEmailAsync(login);

                if (_hasher.VerifyHashedPassword(login, dbUser.Password, password) == PasswordVerificationResult.Failed)
                {
                    throw new AuthenticationException("Invalid email or password.");
                }

                string userName = dbUser.Name;

                // If credentials are valid -> APPROVE the access. If invalid -> REJECT the request.
                byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new LoginResponseModel()
                {
                    Name = userName,
                    MessageContent = Globals.MsgApproveClientRequest
                }));

                // Safely use networkStream. It will be disposed at the end of the block,
                // but client will remain alive because we don't own the socket here.
                using (NetworkStream networkStream = new NetworkStream(client.Client, ownsSocket: false))
                {
                    await networkStream.WriteAsync(buffer, 0, buffer.Length);
                }
            }

        }
        catch (MusicServiceException)
        {
            throw;
        }
        catch (Exception ex)
        {
            // Fixed the error message here to correctly reflect the log-in context instead of sign-up
            throw new DatabaseException("An unexpected error occurred during log-in verification transmission.", ex);
        }
    }
}