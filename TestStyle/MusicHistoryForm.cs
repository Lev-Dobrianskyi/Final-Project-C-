using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Music_App
{
    public partial class MusicHistoryForm : Form
    {
        public MusicHistoryForm()
        {
            InitializeComponent();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowSongs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MakeCircle(Button btn)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void MusicHistoryForm_Load(object sender, EventArgs e)
        {
            MakeCircle(btnSongsLeft);
            MakeCircle(btnSongsLeftPlaylist);
            MakeCircle(btnSongsRight);
            MakeCircle(btnSongsRightPlaylist);
        }
    }


}