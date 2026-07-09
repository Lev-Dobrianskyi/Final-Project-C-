using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Web;
using System.Windows.Forms;
using NAudio.Wave;
using System.Linq;
using MusicAppServer.Models;
using MusicAppServer.Data;
using MusicAppServer.MusicPlayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Music_App;

public partial class SongMenu : Form
{
    public string songTitle;
    public string songAuthor;

    /// <summary>
    /// Creates a new instance of the SongMenu form with the specified title and author.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    public SongMenu(string title, string author, Image image)
    {
        InitializeComponent();

        songTitle = title;
        songAuthor = author;
        SongPicBox.Image = image;
        SongPicBox.SizeMode = PictureBoxSizeMode.Zoom;
        SongNameLabel.Text = title;
        SongAuthorLabel.Text = author;
    }

    private Song currentSong;
    private MusicPlayer player = new MusicPlayer();
    private bool isPlaying;
    //currentSong = await client.GetSongAsync(songTitle, songAuthor);
    //If server will accept request from client and search for song in database,
    //then it will return song object with all necessary information, including url to the song file. 
    //Then this form will use that url to play the song.
    //Also require changes if this method will be added to the server.

    private void SongMenu_Load(object sender, EventArgs e)
    {
        string fileName = "sabrina-carpenter-espresso.mp3";
        string songsDirectory = Path.Combine(AppContext.BaseDirectory, "Songs");
        string filePath = Path.Combine(songsDirectory, fileName);
        songTimer.Start();

        GraphicsPath buttonRoundingPath = new GraphicsPath();
        buttonRoundingPath.AddEllipse(0, 0, Play_PauseBtn.Width, Play_PauseBtn.Height);

        Play_PauseBtn.Region = new Region(buttonRoundingPath);
        SongTrackBar.TickStyle = TickStyle.None;

        player.Load(filePath);

        using (var context = new AppDBContext())
        {
            Song? song = context.Songs
                .Include(s => s.Artists)
                .FirstOrDefault(s =>
                    s.Name.Trim() == songTitle.Trim() &&
                    s.Artists.Any(a => a.Name.Trim() == songAuthor.Trim()));
            currentSong = song;
        }
        


        if (currentSong == null)
        {
            MessageBox.Show("Song was not found.");
            return;
        }
    }
    private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
    {
        if (player.audioFile != null && player.audioFile.Position >= player.audioFile.Length)
        {
            BeginInvoke(new Action(() =>
            {
                Play_PauseBtn.Text = " ▶";
                SongTrackBar.Value = 0;
                CurrSongTimeLabel.Text = "00:00";
            }));
        }
    }
    private void Play_PauseBtn_Click(object sender, EventArgs e)
    {
        string fileName = "sabrina-carpenter-espresso.mp3";
        string songsDirectory = Path.Combine(AppContext.BaseDirectory, "Songs");
        string filePath = Path.Combine(songsDirectory, fileName);

        if (!isPlaying)
        {
            try
            {
                player.Load("D:\\Desktop\\Папки\\IT & Життя\\kontrolni\\FinalProject C#\\FinalProject copy2\\MusicAppServer\\Songs\\sabrina-carpenter-espresso.mp3");
                player.Play();
                isPlaying = true;
                Play_PauseBtn.Text = "⏸";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing song: {ex.Message}");
            }
        }
        else
        {
            player.Pause();
            isPlaying = false;
            Play_PauseBtn.Text = "▶";
        }
    }

    private void songTimer_Tick(object sender, EventArgs e)
    {
        if (player.audioFile != null && player.outputDevice != null && player.outputDevice.PlaybackState == PlaybackState.Playing)
        {
            SongTrackBar.Value = Math.Min((int)player.audioFile.CurrentTime.TotalSeconds, SongTrackBar.Maximum);
            CurrSongTimeLabel.Text = TimeSpan.FromSeconds(player.audioFile.CurrentTime.TotalSeconds).ToString(@"mm\:ss");
        }
    }

    private void SongMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
        player.outputDevice?.Stop();
        player.audioFile?.Dispose();
    }

    private void NextBtn_Click(object sender, EventArgs e)
    {

    }

    private void PreviousBtn_Click(object sender, EventArgs e)
    {

    }

    private void SongTrackBar_Scroll(object sender, EventArgs e)
    {
        int currentTick = SongTrackBar.Value;
        int allTime = player.GetAllTimeOfMusic();
        int currentTime = player.GetCurrentTimeOfMusic();
        int newTime = (int)((double)currentTick / SongTrackBar.Maximum * allTime);
        player.Seek(newTime);


    }
}
