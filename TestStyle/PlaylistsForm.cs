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
            SearchTextBoxPL.PlaceholderText = "Search in playlists...";
        }
        private void SearchBtnPL_MouseEnter(object sender, EventArgs e)
        {
            SearchTextBoxPL.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void SearchBtnPL_MouseLeave(object sender, EventArgs e)
        {
            SearchTextBoxPL.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void PlaylistBox_Enter(object sender, EventArgs e)
        {
            // this is a placeholder for the event handler when the user enters the PlaylistBox, open the playlist when THIS event is triggered
        }
    }
}

