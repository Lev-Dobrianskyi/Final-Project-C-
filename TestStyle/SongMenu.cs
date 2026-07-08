using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;
using System.Linq;
using MusicAppServer;

namespace Music_App
{
    public partial class SongMenu : Form
    {
        public SongMenu()
        {
            InitializeComponent();
        }
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;


        List<Song> songs = new List<Song>();

        private int currentSongIndex = 0;

        private void SongMenu_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();

            GraphicsPath buttonRoundingPath = new GraphicsPath();
            buttonRoundingPath.AddEllipse(0, 0, Play_PauseBtn.Width, Play_PauseBtn.Height);

            Play_PauseBtn.Region = new Region(buttonRoundingPath);
            SongTrackBar.TickStyle = TickStyle.None;

            Song currentSong = songs[0];

            currentSongIndex = 0;

            LoadSong(currentSongIndex);
        }
        private void LoadSong(int index)
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();

            audioFile = new AudioFileReader(songs[index].Url);

            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);

            outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;

            SongNameLabel.Text = songs[index].Name;

            SongAuthorLabel.Text = string.Join(", ", songs[index].Artists.Select(a => a.Name));

            SongTrackBar.Value = Math.Min((int)audioFile.CurrentTime.TotalSeconds, SongTrackBar.Maximum);

            MaxSongTimeLabel.Text = TimeSpan.FromSeconds(audioFile.TotalTime.TotalSeconds).ToString(@"mm\:ss");
            SongTrackBar.Value = 0;
        }
        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFile.Position >= audioFile.Length)
            {
                BeginInvoke(new Action(() =>
                {
                    currentSongIndex++;
                    if(currentSongIndex >= songs.Count)
                    {
                        currentSongIndex = 0;
                    }
                    PlayCurrentSong();
                }));
            }
        }
        private void PlayCurrentSong()
        {
            LoadSong(currentSongIndex);
            outputDevice.Play();
            Play_PauseBtn.Text = " ❚❚";
        }
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
            currentSongIndex++;

            if (currentSongIndex >= songs.Count)
            {
                currentSongIndex = 0;
            }
            PlayCurrentSong();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            currentSongIndex--;
            if (currentSongIndex < 0)
            {
                currentSongIndex = songs.Count - 1;
            }
            PlayCurrentSong();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                SongTrackBar.Value = (int)audioFile.CurrentTime.TotalSeconds;
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
