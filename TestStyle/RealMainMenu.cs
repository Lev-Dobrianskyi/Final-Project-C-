using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestStyle
{
    public partial class RealMainMenu : Form
    {
        public RealMainMenu()
        {
            InitializeComponent();
        }

        private void SearchBtnRMM_Click(object sender, EventArgs e)
        {

        }

        private void PlaylistsBtnRMM_Click(object sender, EventArgs e)
        {
            PlaylistsForm playlistForm = new PlaylistsForm();
            playlistForm.Show();
        }

        private void HistoryBtnRMM_Click(object sender, EventArgs e)
        {

        }

        private void CreateSongBtnRMM_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtnRMM_MouseEnter(object sender, EventArgs e)
        {
            SearchBtnRMM.ForeColor = Color.FromArgb(255, 180, 0);
        }

        private void PlaylistsBtnRMM_MouseEnter(object sender, EventArgs e)
        {
            PlaylistsBtnRMM.ForeColor = Color.FromArgb(255, 180, 0);
        }

        private void HistoryBtnRMM_MouseEnter(object sender, EventArgs e)
        {
            HistoryBtnRMM.ForeColor = Color.FromArgb(255, 180, 0);
        }

        private void CreateSongBtnRMM_MouseEnter(object sender, EventArgs e)
        {
            CreateSongBtnRMM.ForeColor = Color.FromArgb(255, 180, 0);
        }

        private void SearchBtnRMM_MouseLeave(object sender, EventArgs e)
        {
            SearchBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void PlaylistsBtnRMM_MouseLeave(object sender, EventArgs e)
        {
            PlaylistsBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void HistoryBtnRMM_MouseLeave(object sender, EventArgs e)
        {
            HistoryBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void CreateSongBtnRMM_MouseLeave(object sender, EventArgs e)
        {
            CreateSongBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
        }

        
    }
}

