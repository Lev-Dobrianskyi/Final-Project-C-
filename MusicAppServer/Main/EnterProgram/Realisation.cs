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
                TcpClient client = await listener.AcceptTcpClientAsync();
                // Fire off the task to handle this specific client without blocking the acceptance of next clients
                _ = Task.Run(async () =>
                {
                    using (client)
                    using (NetworkStream stream = client.GetStream())
                    {
                        try
                        {
                            byte[] serverBuffer = new byte[4096];
                            int bytesRead = await stream.ReadAsync(serverBuffer, 0, serverBuffer.Length);
                            // Отримуємо наш JSON-рядок від клієнта
                            string jsonRequest = Encoding.UTF8.GetString(serverBuffer, 0, bytesRead);
                            using (JsonDocument doc = JsonDocument.Parse(jsonRequest))
                            {
                                // 2. Дістаємо значення поля "Action"
                                if (!doc.RootElement.TryGetProperty("Action", out JsonElement actionElement))
                                {
                                    throw new AuthenticationException("Missing 'Action' property in request.");
                                }

                                string action = actionElement.GetString();
                                Console.WriteLine(action);
                                // 3. Роутинг за допомогою switch
                                switch (action)
                                {
                                    case "signup":
                                        // Тепер, коли ми знаємо, що це signup, десеріалізуємо у конкретну модель
                                        var signupModel = JsonSerializer.Deserialize<SignupRequestModel>(jsonRequest);
                                        // Викликаємо твій метод перевірки, який ми писали раніше
                                        await Sender.IsSignUpAsync(client, signupModel.Email, signupModel.Password, signupModel.Name);
                                        break;

                                    case "login":
                                        // Тепер, коли ми знаємо, що це login, десеріалізуємо у конкретну модель
                                        var loginModel = JsonSerializer.Deserialize<LoginRequestModel>(jsonRequest);
                                        // Викликаємо твій метод перевірки, який ми писали раніше
                                        await Sender.IsLogInAsync(client, loginModel.Email, loginModel.Password);
                                        break;

                                    case "listenSong":
                                        var listenModel = JsonSerializer.Deserialize<ListenRequestModel>(jsonRequest);
                                        // Передаємо стрім та шлях пісні для відправки треку
                                        await Sender.SendSongAsync(client, listenModel.SongPath, listenModel.startPositionSec);
                                        break;

                                    case "songsRequest":
                                        var songsRequestModel = JsonSerializer.Deserialize<SongsRequestModel>(jsonRequest);
                                        await Sender.SendSongListAsync(client, songsRequestModel.OrderBy, songsRequestModel.OrderDirection);
                                        break;

                                    default:
                                        throw new AuthenticationException($"Invalid action: {action}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // ГАРАНТОВАНА ВІДПОВІДЬ ПРИ ПОМИЛЦІ
                            Console.WriteLine($"[User Error]: {ex.Message}");
                            try
                            {
                                // Якщо сталась помилка, ми пишемо відповідь у ТОЙ САМИЙ стрім, який ще відкритий
                                byte[] errorBuffer = Encoding.UTF8.GetBytes(
                                    JsonSerializer.Serialize(new MessageRequestModel()
                                    {
                                        IsSuccess = false,
                                        MessageContent = ex.Message // Тут повертається чистий текст помилки
                                    })
                                );
                                await stream.WriteAsync(errorBuffer, 0, errorBuffer.Length);
                            }
                            catch (Exception netEx)
                            {
                                Console.WriteLine($"[Failed to send error to client]: {netEx.Message}");
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
