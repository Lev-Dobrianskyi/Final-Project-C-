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
    }
    private AudioFileReader audioFile;
    private WaveOutEvent outputDevice;

    private Song currentSong;
    //currentSong = await client.GetSongAsync(songTitle, songAuthor);
    //If server will accept request from client and search for song in database,
    //then it will return song object with all necessary information, including url to the song file. 
    //Then this form will use that url to play the song.
    //Also require changes if this method will be added to the server.

    private void SongMenu_Load(object sender, EventArgs e)
    {
        songTimer.Start();

        GraphicsPath buttonRoundingPath = new GraphicsPath();
        buttonRoundingPath.AddEllipse(0, 0, Play_PauseBtn.Width, Play_PauseBtn.Height);

        Play_PauseBtn.Region = new Region(buttonRoundingPath);
        SongTrackBar.TickStyle = TickStyle.None;

        LoadSong();

        using var context = new MusicAppServer.AppContext();
        currentSong = context.Songs
            .Include(s => s.Artists)
            .FirstOrDefault(s =>
                s.Name.Trim() == songTitle.Trim() &&
                s.Artists.Any(a => a.Name.Trim() == songAuthor.Trim()));

        if (currentSong == null)
        {
            MessageBox.Show("Song was not found.");
            return;
        }
    }

    private void LoadSong()
    {
        outputDevice?.Stop();
        outputDevice?.Dispose();
        audioFile?.Dispose();

        audioFile = new AudioFileReader(currentSong.Url);

        if (audioFile == null)
        {
            MessageBox.Show("Failed to load song.");
            return;
        }

        outputDevice = new WaveOutEvent();
        outputDevice.Init(audioFile);

        outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;

        SongNameLabel.Text = currentSong.Name;

        SongAuthorLabel.Text = string.Join(", ", currentSong.Artists.Select(a => a.Name));

        SongTrackBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;

        MaxSongTimeLabel.Text = TimeSpan.FromSeconds(audioFile.TotalTime.TotalSeconds).ToString(@"mm\:ss");
        SongTrackBar.Value = 0;

    }

    bool isPlaying = false;
    private void Play_PauseBtn_Click(object sender, EventArgs e)
    {
        if (!isPlaying)
        {
            Play_PauseBtn.Text = " ❚❚";
        }
        else
        {
            Play_PauseBtn.Text = " ▶";
        }

        isPlaying = !isPlaying;
    }
}
