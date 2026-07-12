using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Music_App.Client_class;
using MusicAppServer.Data;
using MusicAppServer.Models;
using MusicAppServer.MusicPlayer;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Web;
using System.Windows.Forms;

namespace Music_App;

public partial class SongMenu : Form
{

    /// <summary>
    /// Creates a new instance of the SongMenu form with the specified title and author.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    private Song currentSong;
    private readonly MusicPlayer player = new MusicPlayer();
    private bool isPlaying;
    private bool isUserScrolling = false;
    private int trackStartSecond = 0;

    public SongMenu(Song song, Image image, string artists)
    {
        InitializeComponent();

        currentSong = song;

        SongPicBox.Image = image;
        SongPicBox.SizeMode = PictureBoxSizeMode.Zoom;

        SongNameLabel.Text = song.Name;
        SongAuthorLabel.Text = artists;
    }
    //currentSong = await client.GetSongAsync(songTitle, songAuthor);
    //If server will accept request from client and search for song in database,
    //then it will return song object with all necessary information, including url to the song file. 
    //Then this form will use that url to play the song.
    //Also require changes if this method will be added to the server.
    private async Task<NetworkStream> GetAudioStreamFromServerAsync(string songPath, int startPositionSec)
    {
        TcpClient client = new TcpClient();
        await client.ConnectAsync("127.0.0.1", 5000);

        NetworkStream stream = client.GetStream();

        var requestModel = new ListenRequestModel
        {
            SongPath = songPath,
            startPositionSec = startPositionSec
        };

        string jsonRequest = JsonSerializer.Serialize(requestModel);
        byte[] requestBuffer = Encoding.UTF8.GetBytes(jsonRequest);

        // Відправляємо запит серверу
        await stream.WriteAsync(requestBuffer, 0, requestBuffer.Length);

        // Повертаємо стрім. Закривати його тут не можна, бо з нього читатиме NAudio
        return stream;
    }

    private void SongMenu_Load(object sender, EventArgs e)
    {
        if (currentSong == null)
        {
            MessageBox.Show("Song not found.");
            Close();
            return;
        }

        songTimer.Start();

        GraphicsPath buttonRoundingPath = new GraphicsPath();
        buttonRoundingPath.AddEllipse(0, 0, Play_PauseBtn.Width, Play_PauseBtn.Height);

        Play_PauseBtn.Region = new Region(buttonRoundingPath);

        SongTrackBar.TickStyle = TickStyle.None;
    }
    private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
    {
        BeginInvoke(new Action(() =>
        {
            isPlaying = false;

            Play_PauseBtn.Text = "▶";

            SongTrackBar.Value = 0;

            CurrSongTimeLabel.Text = "00:00";
        }));
    }
    private async void PlayPause()
    {
        if (currentSong == null)
            return;

        try
        {
            if (!isPlaying)
            {
                if (player.audioFile == null)
                {
                    Play_PauseBtn.Enabled = false;
                    Play_PauseBtn.Text = "/";
                    trackStartSecond = SongTrackBar.Value;
                    NetworkStream audioStream = await GetAudioStreamFromServerAsync(currentSong.Url, trackStartSecond);

                    player.Load(audioStream);

                    if (SongTrackBar.Maximum == 100 && player.GetAllTimeOfMusic() > 0)
                    {
                        SongTrackBar.Maximum = player.GetAllTimeOfMusic();
                    }
                    Play_PauseBtn.Enabled = true;
                }
                player.Play();
                isPlaying = true;
                Play_PauseBtn.Text = "| |";
            }
            else
            {
                player.Pause();

                isPlaying = false;

                Play_PauseBtn.Text = "▶";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void Play_PauseBtn_Click(object sender, EventArgs e)
    {
        PlayPause();
    }

    private void songTimer_Tick(object sender, EventArgs e)
    {
        if (isUserScrolling || player.audioFile == null || player.outputDevice == null)
            return;

        if (player.outputDevice.PlaybackState != PlaybackState.Playing)
            return;

        int actualCurrentSecond = trackStartSecond + player.GetCurrentTimeOfMusic();

        if (actualCurrentSecond <= SongTrackBar.Maximum)
        {
            SongTrackBar.Value = actualCurrentSecond;
            CurrSongTimeLabel.Text = TimeSpan.FromSeconds(actualCurrentSecond).ToString(@"mm\:ss");
        }
        else
        {
            player.outputDevice.Stop();
        }
    }

    private void SongMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        songTimer.Stop();

        player.outputDevice?.Stop();
        player.outputDevice?.Dispose();

        player.audioFile?.Dispose();
    }

    private void NextBtn_Click(object sender, EventArgs e)
    {

    }

    private void PreviousBtn_Click(object sender, EventArgs e)
    {

    }

    private async void SongTrackBar_Scroll(object sender, EventArgs e)
    {
        try
        {
            isUserScrolling = true;

            player.outputDevice?.Stop();

            player.ResetAudioFile();

            int targetSecond = SongTrackBar.Value;
            trackStartSecond = targetSecond;

            CurrSongTimeLabel.Text = TimeSpan.FromSeconds(targetSecond).ToString(@"mm\:ss");

            if (isPlaying)
            {
                Play_PauseBtn.Enabled = false;
                Play_PauseBtn.Text = "/";

                NetworkStream newStream = await GetAudioStreamFromServerAsync(currentSong.Url, targetSecond);
                player.Load(newStream);

                player.Play();
                Play_PauseBtn.Enabled = true;
                Play_PauseBtn.Text = "| |";
            }
            else
            {
            }
        }
        catch (Exception ex)
        {
            Play_PauseBtn.Enabled = true;
            MessageBox.Show($"Помилка перемотування: {ex.Message}");
        }
        finally
        {
            isUserScrolling = false;
        }
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
    }
}
