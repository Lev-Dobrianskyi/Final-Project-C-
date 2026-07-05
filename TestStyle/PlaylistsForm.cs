using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace TestStyle
{
    public partial class PlaylistsForm : Form
    {
        public PlaylistsForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Play_PauseBtn.Width, Play_PauseBtn.Height);

            Play_PauseBtn.Region = new Region(path);
            SongTrackBar.TickStyle = TickStyle.None;

            int songTime = MaxSongTimeLabel.Text.Length;

            SongTrackBar.Maximum = songTime;

            SearchTextBoxPL.PlaceholderText = "Search in playlists...";
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

        private void PreviousBtn_Click(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtnPL_MouseEnter(object sender, EventArgs e)
        {
            SearchTextBoxPL.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void SearchBtnPL_MouseLeave(object sender, EventArgs e)
        {
            SearchTextBoxPL.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void SearchBtnPL_Click(object sender, EventArgs e)
        {

        }

        private void PlaylistBox_Enter(object sender, EventArgs e)
        {
            // this is a placeholder for the event handler when the user enters the PlaylistBox, open the playlist when THIS event is triggered
        }
    }
}

