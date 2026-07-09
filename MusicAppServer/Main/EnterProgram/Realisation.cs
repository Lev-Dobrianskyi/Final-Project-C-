using MusicAppServer.Exceptions;
using MusicAppServer.Main.ServerConstructors;
using System.Net;
using System.Net.Sockets;

namespace MusicAppServer.Main.EnterProgram;

/// <summary>
/// Contains the implementation of the server application, including the entry point and TCP listener loop.
/// </summary>
public class Realisation
{
    /// <summary>
    /// Defines the entry point of the server application, initializing the TCP listener loop.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    public static async Task EnterProgram()
    {
        TcpListener listener = new TcpListener(IPAddress.Any, 5000);
        listener.Start();

        Console.WriteLine(Globals.MsgServerStarted);

        while (true)
        {
            try
            {
                TcpClient client = await listener.AcceptTcpClientAsync();

                // Fire off the task to handle this specific client without blocking the acceptance of next clients
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await Sender.SendSongAsync(client, @"Music\song.mp3");
                    }
                    catch (MusicServiceException serviceEx)
                    {
                        Console.WriteLine($"[Service Error]: {serviceEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[Unexpected Server Error]: {ex.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Connection Accept Error]: {ex.Message}");
            }
        }
    }
}
