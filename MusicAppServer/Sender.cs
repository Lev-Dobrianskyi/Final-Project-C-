using System.Net.Sockets;
using System.Text;

namespace MusicAppServer;


/// <summary>
/// Provides functionality to stream audio files to connected TCP clients.
/// </summary>
public static class Sender
{
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
            throw new ArgumentNullException(nameof(client));

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
    /// Asynchronously processes a user sign-up request by verifying the email and sending the appropriate encoded global response message to the client.
    /// </summary>
    /// <param name="client">The active TCP client connection.</param>
    /// <param name="login">The email address or login identifier submitted by the client.</param>
    /// <returns>A task that represents the asynchronous verification and response operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="client"/> or <paramref name="login"/> is null.</exception>
    /// <exception cref="DatabaseException">Thrown when the database queries fail during verification.</exception>
    public static async Task IsSignUpAsync(TcpClient client, string login)
    {
        if (client == null)
            throw new ArgumentNullException(nameof(client));

        if (login == null)
            throw new ArgumentNullException(nameof(login));

        try
        {
            bool canSign;

            // Context is disposed immediately after fetching data
            using (var context = new AppContext())
            {
                var userController = new UserController(context);
                canSign = !await userController.IsUserExistsByEmailAsync(login);
            }

            byte[] buffer = canSign
                ? Encoding.UTF8.GetBytes(Globals.MsgApproveClientRequest)
                : Encoding.UTF8.GetBytes(Globals.MsgRejectClientRequest);

            // Safely use networkStream. It will be disposed at the end of the block,
            // but client will remain alive because we don't own the socket here.
            using (NetworkStream networkStream = new NetworkStream(client.Client, ownsSocket: false))
            {
                await networkStream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        catch (MusicServiceException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new DatabaseException("An unexpected error occurred during sign-up verification transmission.", ex);
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
            bool canLog;

            // Context is disposed immediately after fetching data
            using (var context = new AppContext())
            {
                var userController = new UserController(context);
                // Straightforward logic: if credentials match — true, otherwise — false
                canLog = await userController.VerifyUserCredentialsAsync(login, password);
            }

            // If credentials are valid -> APPROVE the access. If invalid -> REJECT the request.
            byte[] buffer = canLog
                ? Encoding.UTF8.GetBytes(Globals.MsgApproveClientRequest)
                : Encoding.UTF8.GetBytes(Globals.MsgRejectClientRequest);

            // Safely use networkStream. It will be disposed at the end of the block,
            // but client will remain alive because we don't own the socket here.
            using (NetworkStream networkStream = new NetworkStream(client.Client, ownsSocket: false))
            {
                await networkStream.WriteAsync(buffer, 0, buffer.Length);
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