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
using MusicAppServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace TestStyle
{
    public partial class SongMenu : Form
    {
        public string songTitle;
        public string songAuthor;
        public SongMenu(string title, string author)
        {
            songTitle = title;
            songAuthor = author;
            InitializeComponent();
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
            timer1.Interval = 500;
            timer1.Start();

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

            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);

            outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;

            SongNameLabel.Text = currentSong.Name;

            SongAuthorLabel.Text = string.Join(", ", currentSong.Artists.Select(a => a.Name));

            SongTrackBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;

            MaxSongTimeLabel.Text = TimeSpan.FromSeconds(audioFile.TotalTime.TotalSeconds).ToString(@"mm\:ss");
            SongTrackBar.Value = 0;
        }
        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFile != null &&audioFile.Position >= audioFile.Length)
            {
                BeginInvoke(new Action(() =>
                {
                    Play_PauseBtn.Text = " ▶";
                    SongTrackBar.Value = 0;
                    CurrSongTimeLabel.Text = "00:00";
                }));
            }
        }

        //private void PlayCurrentSong()
        //{
        //    LoadSong(currentSongIndex);
        //    outputDevice.Play();
        //    Play_PauseBtn.Text = " ❚❚";
        //}

        //This method was supposed to start playing current song,
        //but it was commented out because all buttons which involves it won't work 
        private void Play_PauseBtn_Click(object sender, EventArgs e)
        {

            if (outputDevice == null)
            {
                return;
            }
            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                Play_PauseBtn.Text = " ▶";
            }
            else
            {
                if (audioFile.Position >= audioFile.Length)
                {
                    audioFile.Position = 0;
                }

                outputDevice.Play();
                Play_PauseBtn.Text = " ❚❚";
            }

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            //currentSongIndex++;

            //if (currentSongIndex >= songs.Count)
            //{
            //    currentSongIndex = 0;
            //}
            //PlayCurrentSong();
        }
       
        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            //currentSongIndex--;
            //if (currentSongIndex < 0)
            //{
            //    currentSongIndex = songs.Count - 1;
            //}
            //PlayCurrentSong();
        }
        // This methods are commented out because they can't work properly because of lack of songs list,
        // so this form accept only 1 song at a time
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                SongTrackBar.Value = Math.Min((int)audioFile.CurrentTime.TotalSeconds, SongTrackBar.Maximum);
                CurrSongTimeLabel.Text = TimeSpan.FromSeconds(audioFile.CurrentTime.TotalSeconds).ToString(@"mm\:ss");
            }
        }

        private void SongMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            outputDevice?.Dispose();
            audioFile?.Dispose();


        }
    }

}
