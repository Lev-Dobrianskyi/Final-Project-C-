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

    public static async Task IsSignUpAsync(TcpClient client, string login)
    {
        if (client == null)
            throw new ArgumentNullException(nameof(client));

        if (login == null)
            throw new ArgumentNullException(nameof(login));

        try
        {
            using (var context = new AppContext())
            {
                var userController = new UserController(context);
                bool userExists = await userController.IsUserExistsByEmailAsync(login);

                // Open the stream without disposing the client itself, keeping the connection alive for further communication
                NetworkStream networkStream = client.GetStream();

                byte[] buffer = userExists ? Encoding.UTF8.GetBytes(Globals.MsgApproveClientRequest) : Encoding.UTF8.GetBytes(Globals.MsgRejectClientRequest);

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
}