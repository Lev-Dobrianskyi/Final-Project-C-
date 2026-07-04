using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TestStyle
{
    partial class PlaylistsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlaylistFLP = new FlowLayoutPanel();
            PlaylistPanel = new Panel();
            PlaylistSongsDGV = new DataGridView();
            PlaylistAuthorLabel = new Label();
            PlaylistNameLabel = new Label();
            PlaylistPicBox = new PictureBox();
            panel1 = new Panel();
            PlaylistsTEXT = new Label();
            panel2 = new Panel();
            MaxSongTimeLabel = new Label();
            CurrSongTimeLabel = new Label();
            SongTrackBar = new TrackBar();
            NextBtn = new Button();
            PreviousBtn = new Button();
            Play_PauseBtn = new Button();
            SongAuthorLabel = new Label();
            SongNameLabel = new Label();
            SongPicBox = new PictureBox();
            PlaylistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlaylistSongsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlaylistPicBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).BeginInit();
            SuspendLayout();
            // 
            // PlaylistFLP
            // 
            PlaylistFLP.AutoScroll = true;
            PlaylistFLP.BackColor = Color.FromArgb(40, 40, 40);
            PlaylistFLP.BorderStyle = BorderStyle.FixedSingle;
            PlaylistFLP.Location = new Point(3, 117);
            PlaylistFLP.Name = "PlaylistFLP";
            PlaylistFLP.Size = new Size(282, 417);
            PlaylistFLP.TabIndex = 0;
            // 
            // PlaylistPanel
            // 
            PlaylistPanel.AutoScroll = true;
            PlaylistPanel.BackColor = Color.FromArgb(30, 30, 30);
            PlaylistPanel.BorderStyle = BorderStyle.FixedSingle;
            PlaylistPanel.Controls.Add(PlaylistSongsDGV);
            PlaylistPanel.Controls.Add(PlaylistAuthorLabel);
            PlaylistPanel.Controls.Add(PlaylistNameLabel);
            PlaylistPanel.Controls.Add(PlaylistPicBox);
            PlaylistPanel.Location = new Point(306, 12);
            PlaylistPanel.Name = "PlaylistPanel";
            PlaylistPanel.Size = new Size(702, 537);
            PlaylistPanel.TabIndex = 2;
            // 
            // PlaylistSongsDGV
            // 
            PlaylistSongsDGV.BackgroundColor = Color.FromArgb(30, 30, 30);
            PlaylistSongsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlaylistSongsDGV.GridColor = SystemColors.Control;
            PlaylistSongsDGV.Location = new Point(17, 245);
            PlaylistSongsDGV.Name = "PlaylistSongsDGV";
            PlaylistSongsDGV.RowHeadersWidth = 51;
            PlaylistSongsDGV.Size = new Size(651, 369);
            PlaylistSongsDGV.TabIndex = 3;
            // 
            // PlaylistAuthorLabel
            // 
            PlaylistAuthorLabel.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaylistAuthorLabel.ForeColor = SystemColors.ControlDark;
            PlaylistAuthorLabel.Location = new Point(247, 88);
            PlaylistAuthorLabel.Name = "PlaylistAuthorLabel";
            PlaylistAuthorLabel.Size = new Size(260, 44);
            PlaylistAuthorLabel.TabIndex = 2;
            PlaylistAuthorLabel.Text = "Playlist Author";
            // 
            // PlaylistNameLabel
            // 
            PlaylistNameLabel.AutoEllipsis = true;
            PlaylistNameLabel.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlaylistNameLabel.ForeColor = SystemColors.Control;
            PlaylistNameLabel.Location = new Point(237, 38);
            PlaylistNameLabel.Name = "PlaylistNameLabel";
            PlaylistNameLabel.Size = new Size(270, 50);
            PlaylistNameLabel.TabIndex = 1;
            PlaylistNameLabel.Text = "Playlist Name";
            // 
            // PlaylistPicBox
            // 
            PlaylistPicBox.BorderStyle = BorderStyle.FixedSingle;
            PlaylistPicBox.Location = new Point(17, 22);
            PlaylistPicBox.Name = "PlaylistPicBox";
            PlaylistPicBox.Size = new Size(214, 196);
            PlaylistPicBox.TabIndex = 0;
            PlaylistPicBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(PlaylistsTEXT);
            panel1.Controls.Add(PlaylistFLP);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 537);
            panel1.TabIndex = 3;
            // 
            // PlaylistsTEXT
            // 
            PlaylistsTEXT.AutoSize = true;
            PlaylistsTEXT.Font = new Font("Sitka Banner", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlaylistsTEXT.ForeColor = Color.FromArgb(255, 128, 0);
            PlaylistsTEXT.Location = new Point(3, 52);
            PlaylistsTEXT.Name = "PlaylistsTEXT";
            PlaylistsTEXT.Size = new Size(160, 62);
            PlaylistsTEXT.TabIndex = 1;
            PlaylistsTEXT.Text = "Playlists";
            // 
            // panel2
            // 
            panel2.Controls.Add(MaxSongTimeLabel);
            panel2.Controls.Add(CurrSongTimeLabel);
            panel2.Controls.Add(SongTrackBar);
            panel2.Controls.Add(NextBtn);
            panel2.Controls.Add(PreviousBtn);
            panel2.Controls.Add(Play_PauseBtn);
            panel2.Controls.Add(SongAuthorLabel);
            panel2.Controls.Add(SongNameLabel);
            panel2.Controls.Add(SongPicBox);
            panel2.ForeColor = Color.FromArgb(15, 15, 15);
            panel2.Location = new Point(0, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 129);
            panel2.TabIndex = 4;
            // 
            // MaxSongTimeLabel
            // 
            MaxSongTimeLabel.AutoSize = true;
            MaxSongTimeLabel.ForeColor = Color.White;
            MaxSongTimeLabel.Location = new Point(677, 94);
            MaxSongTimeLabel.Name = "MaxSongTimeLabel";
            MaxSongTimeLabel.Size = new Size(44, 20);
            MaxSongTimeLabel.TabIndex = 8;
            MaxSongTimeLabel.Text = "99:99";
            // 
            // CurrSongTimeLabel
            // 
            CurrSongTimeLabel.AutoSize = true;
            CurrSongTimeLabel.BackColor = Color.FromArgb(20, 20, 20);
            CurrSongTimeLabel.ForeColor = Color.White;
            CurrSongTimeLabel.Location = new Point(295, 94);
            CurrSongTimeLabel.Name = "CurrSongTimeLabel";
            CurrSongTimeLabel.Size = new Size(44, 20);
            CurrSongTimeLabel.TabIndex = 7;
            CurrSongTimeLabel.Text = "00:00";
            // 
            // SongTrackBar
            // 
            SongTrackBar.Location = new Point(351, 87);
            SongTrackBar.Name = "SongTrackBar";
            SongTrackBar.Size = new Size(320, 56);
            SongTrackBar.TabIndex = 6;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(20, 20, 20);
            NextBtn.Cursor = Cursors.Hand;
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Font = new Font("Segoe UI Symbol", 16F);
            NextBtn.ForeColor = Color.FromArgb(255, 128, 0);
            NextBtn.Location = new Point(550, 20);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(29, 47);
            NextBtn.TabIndex = 5;
            NextBtn.Text = "⏭";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // PreviousBtn
            // 
            PreviousBtn.BackColor = Color.FromArgb(20, 20, 20);
            PreviousBtn.Cursor = Cursors.Hand;
            PreviousBtn.FlatAppearance.BorderSize = 0;
            PreviousBtn.FlatStyle = FlatStyle.Flat;
            PreviousBtn.Font = new Font("Segoe UI Symbol", 16F);
            PreviousBtn.ForeColor = Color.FromArgb(255, 128, 0);
            PreviousBtn.Location = new Point(441, 19);
            PreviousBtn.Margin = new Padding(0);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(28, 49);
            PreviousBtn.TabIndex = 4;
            PreviousBtn.Text = "⏮";
            PreviousBtn.UseVisualStyleBackColor = false;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // Play_PauseBtn
            // 
            Play_PauseBtn.BackColor = Color.FromArgb(255, 128, 0);
            Play_PauseBtn.Cursor = Cursors.Hand;
            Play_PauseBtn.FlatAppearance.BorderSize = 0;
            Play_PauseBtn.FlatStyle = FlatStyle.Flat;
            Play_PauseBtn.Font = new Font("Arial", 18F, FontStyle.Bold);
            Play_PauseBtn.ForeColor = Color.Black;
            Play_PauseBtn.Location = new Point(478, 13);
            Play_PauseBtn.Margin = new Padding(0);
            Play_PauseBtn.Name = "Play_PauseBtn";
            Play_PauseBtn.Size = new Size(60, 60);
            Play_PauseBtn.TabIndex = 3;
            Play_PauseBtn.Text = " ▶";
            Play_PauseBtn.UseVisualStyleBackColor = false;
            Play_PauseBtn.Click += Play_PauseBtn_Click;
            // 
            // SongAuthorLabel
            // 
            SongAuthorLabel.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SongAuthorLabel.ForeColor = SystemColors.ControlDark;
            SongAuthorLabel.Location = new Point(115, 52);
            SongAuthorLabel.Name = "SongAuthorLabel";
            SongAuthorLabel.Size = new Size(230, 42);
            SongAuthorLabel.TabIndex = 2;
            SongAuthorLabel.Text = "Song Author";
            // 
            // SongNameLabel
            // 
            SongNameLabel.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SongNameLabel.ForeColor = SystemColors.Control;
            SongNameLabel.Location = new Point(115, 13);
            SongNameLabel.Name = "SongNameLabel";
            SongNameLabel.Size = new Size(230, 39);
            SongNameLabel.TabIndex = 1;
            SongNameLabel.Text = "Song Name";
            // 
            // SongPicBox
            // 
            SongPicBox.Location = new Point(12, 13);
            SongPicBox.Name = "SongPicBox";
            SongPicBox.Size = new Size(97, 81);
            SongPicBox.TabIndex = 0;
            SongPicBox.TabStop = false;
            // 
            // PlaylistsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1020, 683);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PlaylistPanel);
            Name = "PlaylistsForm";
            Text = "Form2";
            Load += Form2_Load;
            PlaylistPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlaylistSongsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlaylistPicBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel PlaylistFLP;
        private Panel PlaylistPanel;
        private PictureBox PlaylistPicBox;
        private Label PlaylistNameLabel;
        private Label PlaylistAuthorLabel;
        private DataGridView PlaylistSongsDGV;
        private Panel panel1;
        private Label PlaylistsTEXT;
        private Panel panel2;
        private PictureBox SongPicBox;
        private Label SongNameLabel;
        private Label SongAuthorLabel;
        private Button NextBtn;
        private Button PreviousBtn;
        private Button Play_PauseBtn;
        private TrackBar SongTrackBar;
        private Label MaxSongTimeLabel;
        private Label CurrSongTimeLabel;
    }
}