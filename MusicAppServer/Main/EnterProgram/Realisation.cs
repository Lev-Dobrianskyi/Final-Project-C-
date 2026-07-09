using Microsoft.EntityFrameworkCore;
using Music_App.Client_class;
using MusicAppServer.Controllers;
using MusicAppServer.Data;
using MusicAppServer.Exceptions;
using MusicAppServer.Main.ServerConstructors;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

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
        TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);
        listener.Start();
        DbControll.ResetDb();

        Console.WriteLine(Globals.MsgServerStarted);

        while (true)
        {
            try
            {
                Console.WriteLine("0");
                TcpClient client = await listener.AcceptTcpClientAsync();
                Console.WriteLine("7");
                // Fire off the task to handle this specific client without blocking the acceptance of next clients
                _ = Task.Run(async () =>
                {
                    Console.WriteLine("17");

                    using (client)
                    using (NetworkStream stream = client.GetStream())
                    {
                        Console.WriteLine("27");
                        byte[] serverBuffer = new byte[4096];
                        int bytesRead = await stream.ReadAsync(serverBuffer, 0, serverBuffer.Length);
                        Console.WriteLine("27");
                        // Отримуємо наш JSON-рядок від клієнта
                        string jsonRequest = Encoding.UTF8.GetString(serverBuffer, 0, bytesRead);
                        Console.WriteLine("37");
                        using (JsonDocument doc = JsonDocument.Parse(jsonRequest))
                        {
                            Console.WriteLine("47");
                            // 2. Дістаємо значення поля "Action"
                            if (!doc.RootElement.TryGetProperty("Action", out JsonElement actionElement))
                            {
                                throw new AuthenticationException("Missing 'Action' property in request.");
                            }

                            string action = actionElement.GetString();
                            Console.WriteLine("57");
                            Console.WriteLine(action);
                            // 3. Роутинг за допомогою switch
                            switch (action)
                            {
                                case "signup":
                                    Console.WriteLine("67.5");
                                    // Тепер, коли ми знаємо, що це signup, десеріалізуємо у конкретну модель
                                    var signupModel = JsonSerializer.Deserialize<SignupRequestModel>(jsonRequest);
                                    // Викликаємо твій метод перевірки, який ми писали раніше
                                    Console.WriteLine("67.75");
                                    await Sender.IsSignUpAsync(client, signupModel.Email, signupModel.Password, signupModel.Name);
                                    Console.WriteLine("67");
                                    break;

                                case "listenSong":
                                    var listenModel = JsonSerializer.Deserialize<ListenRequestModel>(jsonRequest);
                                    // Передаємо стрім та назву пісні для відправки треку
                                    await Sender.SendSongAsync(client, listenModel.SongName);
                                    break;

                                //case "GetSongList":
                                //    await Sender.SendSongListAsync(stream);
                                //    break;

                                default:
                                    throw new AuthenticationException($"Invalid action: {action}");
                            }
                        }
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
