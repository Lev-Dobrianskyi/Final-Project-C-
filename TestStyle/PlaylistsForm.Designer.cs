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
            SearchTextBoxPL = new TextBox();
            SearchBtnPL = new Button();
            PlaylistBox = new GroupBox();
            PlaylistLengthLabel = new Label();
            PlaylistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlaylistSongsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlaylistPicBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).BeginInit();
            PlaylistBox.SuspendLayout();
            SuspendLayout();
            // 
            // PlaylistFLP
            // 
            PlaylistFLP.AutoScroll = true;
            PlaylistFLP.BackColor = Color.FromArgb(40, 40, 40);
            PlaylistFLP.BorderStyle = BorderStyle.FixedSingle;
            PlaylistFLP.Location = new Point(3, 2);
            PlaylistFLP.Margin = new Padding(3, 2, 3, 2);
            PlaylistFLP.Name = "PlaylistFLP";
            PlaylistFLP.Size = new Size(247, 399);
            PlaylistFLP.TabIndex = 0;
            // 
            // PlaylistPanel
            // 
            PlaylistPanel.AutoScroll = true;
            PlaylistPanel.BackColor = Color.FromArgb(30, 30, 30);
            PlaylistPanel.BorderStyle = BorderStyle.FixedSingle;
            PlaylistPanel.Controls.Add(PlaylistBox);
            PlaylistPanel.Controls.Add(PlaylistSongsDGV);
            PlaylistPanel.Location = new Point(268, 68);
            PlaylistPanel.Margin = new Padding(3, 2, 3, 2);
            PlaylistPanel.Name = "PlaylistPanel";
            PlaylistPanel.Size = new Size(614, 403);
            PlaylistPanel.TabIndex = 2;
            // 
            // PlaylistSongsDGV
            // 
            PlaylistSongsDGV.BackgroundColor = Color.FromArgb(30, 30, 30);
            PlaylistSongsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlaylistSongsDGV.GridColor = SystemColors.Control;
            PlaylistSongsDGV.Location = new Point(15, 184);
            PlaylistSongsDGV.Margin = new Padding(3, 2, 3, 2);
            PlaylistSongsDGV.Name = "PlaylistSongsDGV";
            PlaylistSongsDGV.RowHeadersWidth = 51;
            PlaylistSongsDGV.Size = new Size(570, 277);
            PlaylistSongsDGV.TabIndex = 3;
            // 
            // PlaylistAuthorLabel
            // 
            PlaylistAuthorLabel.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaylistAuthorLabel.ForeColor = SystemColors.ControlDark;
            PlaylistAuthorLabel.Location = new Point(192, 57);
            PlaylistAuthorLabel.Name = "PlaylistAuthorLabel";
            PlaylistAuthorLabel.Size = new Size(228, 33);
            PlaylistAuthorLabel.TabIndex = 2;
            PlaylistAuthorLabel.Text = "Playlist Author";
            // 
            // PlaylistNameLabel
            // 
            PlaylistNameLabel.AutoEllipsis = true;
            PlaylistNameLabel.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlaylistNameLabel.ForeColor = SystemColors.Control;
            PlaylistNameLabel.Location = new Point(192, 19);
            PlaylistNameLabel.Name = "PlaylistNameLabel";
            PlaylistNameLabel.Size = new Size(236, 38);
            PlaylistNameLabel.TabIndex = 1;
            PlaylistNameLabel.Text = "Playlist Name";
            // 
            // PlaylistPicBox
            // 
            PlaylistPicBox.BorderStyle = BorderStyle.FixedSingle;
            PlaylistPicBox.Location = new Point(8, 16);
            PlaylistPicBox.Margin = new Padding(3, 2, 3, 2);
            PlaylistPicBox.Name = "PlaylistPicBox";
            PlaylistPicBox.Size = new Size(130, 130);
            PlaylistPicBox.TabIndex = 0;
            PlaylistPicBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(PlaylistFLP);
            panel1.Location = new Point(10, 68);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 403);
            panel1.TabIndex = 3;
            // 
            // PlaylistsTEXT
            // 
            PlaylistsTEXT.AutoSize = true;
            PlaylistsTEXT.Font = new Font("Sitka Banner", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlaylistsTEXT.ForeColor = Color.FromArgb(255, 128, 0);
            PlaylistsTEXT.Location = new Point(13, 19);
            PlaylistsTEXT.Name = "PlaylistsTEXT";
            PlaylistsTEXT.Size = new Size(129, 50);
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
            panel2.Location = new Point(0, 475);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 97);
            panel2.TabIndex = 4;
            // 
            // MaxSongTimeLabel
            // 
            MaxSongTimeLabel.AutoSize = true;
            MaxSongTimeLabel.ForeColor = Color.White;
            MaxSongTimeLabel.Location = new Point(592, 70);
            MaxSongTimeLabel.Name = "MaxSongTimeLabel";
            MaxSongTimeLabel.Size = new Size(34, 15);
            MaxSongTimeLabel.TabIndex = 8;
            MaxSongTimeLabel.Text = "99:99";
            // 
            // CurrSongTimeLabel
            // 
            CurrSongTimeLabel.AutoSize = true;
            CurrSongTimeLabel.BackColor = Color.FromArgb(20, 20, 20);
            CurrSongTimeLabel.ForeColor = Color.White;
            CurrSongTimeLabel.Location = new Point(258, 70);
            CurrSongTimeLabel.Name = "CurrSongTimeLabel";
            CurrSongTimeLabel.Size = new Size(34, 15);
            CurrSongTimeLabel.TabIndex = 7;
            CurrSongTimeLabel.Text = "00:00";
            // 
            // SongTrackBar
            // 
            SongTrackBar.Location = new Point(307, 65);
            SongTrackBar.Margin = new Padding(3, 2, 3, 2);
            SongTrackBar.Name = "SongTrackBar";
            SongTrackBar.Size = new Size(280, 45);
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
            NextBtn.Location = new Point(481, 15);
            NextBtn.Margin = new Padding(3, 2, 3, 2);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(25, 35);
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
            PreviousBtn.Location = new Point(386, 14);
            PreviousBtn.Margin = new Padding(0);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(24, 37);
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
            Play_PauseBtn.Location = new Point(418, 10);
            Play_PauseBtn.Margin = new Padding(0);
            Play_PauseBtn.Name = "Play_PauseBtn";
            Play_PauseBtn.Size = new Size(52, 45);
            Play_PauseBtn.TabIndex = 3;
            Play_PauseBtn.Text = " ▶";
            Play_PauseBtn.UseVisualStyleBackColor = false;
            Play_PauseBtn.Click += Play_PauseBtn_Click;
            // 
            // SongAuthorLabel
            // 
            SongAuthorLabel.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SongAuthorLabel.ForeColor = SystemColors.ControlDark;
            SongAuthorLabel.Location = new Point(101, 39);
            SongAuthorLabel.Name = "SongAuthorLabel";
            SongAuthorLabel.Size = new Size(201, 32);
            SongAuthorLabel.TabIndex = 2;
            SongAuthorLabel.Text = "Song Author";
            // 
            // SongNameLabel
            // 
            SongNameLabel.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SongNameLabel.ForeColor = SystemColors.Control;
            SongNameLabel.Location = new Point(101, 10);
            SongNameLabel.Name = "SongNameLabel";
            SongNameLabel.Size = new Size(201, 29);
            SongNameLabel.TabIndex = 1;
            SongNameLabel.Text = "Song Name";
            // 
            // SongPicBox
            // 
            SongPicBox.Location = new Point(10, 10);
            SongPicBox.Margin = new Padding(3, 2, 3, 2);
            SongPicBox.Name = "SongPicBox";
            SongPicBox.Size = new Size(85, 61);
            SongPicBox.TabIndex = 0;
            SongPicBox.TabStop = false;
            // 
            // SearchTextBoxPL
            // 
            SearchTextBoxPL.BackColor = Color.FromArgb(50, 50, 50);
            SearchTextBoxPL.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBoxPL.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchTextBoxPL.ForeColor = SystemColors.Control;
            SearchTextBoxPL.Location = new Point(284, 19);
            SearchTextBoxPL.Margin = new Padding(3, 2, 3, 2);
            SearchTextBoxPL.Name = "SearchTextBoxPL";
            SearchTextBoxPL.Size = new Size(233, 35);
            SearchTextBoxPL.TabIndex = 5;
            // 
            // SearchBtnPL
            // 
            SearchBtnPL.BackColor = SystemColors.ScrollBar;
            SearchBtnPL.FlatStyle = FlatStyle.System;
            SearchBtnPL.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBtnPL.ForeColor = Color.Black;
            SearchBtnPL.Location = new Point(522, 19);
            SearchBtnPL.Margin = new Padding(3, 2, 3, 2);
            SearchBtnPL.Name = "SearchBtnPL";
            SearchBtnPL.Size = new Size(82, 31);
            SearchBtnPL.TabIndex = 6;
            SearchBtnPL.Text = "Search";
            SearchBtnPL.UseVisualStyleBackColor = false;
            SearchBtnPL.Click += SearchBtnPL_Click;
            SearchBtnPL.MouseEnter += SearchBtnPL_MouseEnter;
            SearchBtnPL.MouseLeave += SearchBtnPL_MouseLeave;
            // 
            // PlaylistBox
            // 
            PlaylistBox.Controls.Add(PlaylistLengthLabel);
            PlaylistBox.Controls.Add(PlaylistPicBox);
            PlaylistBox.Controls.Add(PlaylistNameLabel);
            PlaylistBox.Controls.Add(PlaylistAuthorLabel);
            PlaylistBox.Location = new Point(15, 3);
            PlaylistBox.Name = "PlaylistBox";
            PlaylistBox.Size = new Size(570, 155);
            PlaylistBox.TabIndex = 0;
            PlaylistBox.TabStop = false;
            PlaylistBox.Enter += PlaylistBox_Enter;
            // 
            // PlaylistLengthLabel
            // 
            PlaylistLengthLabel.Font = new Font("Sitka Banner", 14F);
            PlaylistLengthLabel.ForeColor = SystemColors.ControlDark;
            PlaylistLengthLabel.Location = new Point(192, 90);
            PlaylistLengthLabel.Name = "PlaylistLengthLabel";
            PlaylistLengthLabel.Size = new Size(228, 27);
            PlaylistLengthLabel.TabIndex = 3;
            PlaylistLengthLabel.Text = "99:99";
            // 
            // PlaylistsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(892, 569);
            Controls.Add(PlaylistsTEXT);
            Controls.Add(SearchBtnPL);
            Controls.Add(SearchTextBoxPL);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PlaylistPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlaylistsForm";
            Text = "PLaylists";
            Load += Form2_Load;
            PlaylistPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlaylistSongsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlaylistPicBox).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).EndInit();
            PlaylistBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox SearchTextBoxPL;
        private Button SearchBtnPL;
        private GroupBox PlaylistBox;
        private Label PlaylistLengthLabel;
    }
}