using System.Net;
using System.Net.Sockets;

namespace MusicAppServer
{
    class Sender {
        public static async Task SendSong(TcpClient client)
        {
            _ = Task.Run(async () =>
            {
                using (client)
                using (NetworkStream network = client.GetStream())
                using (FileStream file = File.OpenRead(@"Music\song.mp3"))
                {
                    byte[] buffer = new byte[32 * 1024];

                    int bytesRead;

                    while ((bytesRead = await file.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await network.WriteAsync(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine("Пісня відправлена.");
            });
        }
    };

    internal class Program
    {
        static async Task Main(string[] args)
        {

            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();

            Console.WriteLine("Сервер запущено...");

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();

                
            }
        }
    }
}
