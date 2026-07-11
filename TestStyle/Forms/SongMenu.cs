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

    /// <summary>
    /// Creates a new instance of the SongMenu form with the specified title and author.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    private Song currentSong;
    private readonly MusicPlayer player = new MusicPlayer();
    private bool isPlaying;

    public SongMenu(Song song, Image image)
    {
        InitializeComponent();

        currentSong = song;

        SongPicBox.Image = image;
        SongPicBox.SizeMode = PictureBoxSizeMode.Zoom;

        SongNameLabel.Text = song.Name;
        SongAuthorLabel.Text = song.Artists.FirstOrDefault()?.Name ?? "Unknown";
    }
    //currentSong = await client.GetSongAsync(songTitle, songAuthor);
    //If server will accept request from client and search for song in database,
    //then it will return song object with all necessary information, including url to the song file. 
    //Then this form will use that url to play the song.
    //Also require changes if this method will be added to the server.

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
    private void PlayPause()
    {
        if (currentSong == null)
            return;

        try
        {
            if (!isPlaying)
            {
                if (player.audioFile == null)
                {
                    player.Load(currentSong.Url);

                    SongTrackBar.Maximum = player.GetAllTimeOfMusic();
                }

                player.Play();

                isPlaying = true;

                Play_PauseBtn.Text = "⏸";
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
        if (player.audioFile == null)
            return;

        if (player.outputDevice == null)
            return;

        if (player.outputDevice.PlaybackState != PlaybackState.Playing)
            return;

        SongTrackBar.Value = player.GetCurrentTimeOfMusic();

        CurrSongTimeLabel.Text =
            player.audioFile.CurrentTime.ToString(@"mm\:ss");
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

    private void SongTrackBar_Scroll(object sender, EventArgs e)
    {
        if (player.audioFile == null)
            return;

        player.Seek(SongTrackBar.Value);
    }
}
