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
            PlaylistBox = new GroupBox();
            PlaylistLengthLabel = new Label();
            PlaylistPicBox = new PictureBox();
            PlaylistNameLabel = new Label();
            PlaylistAuthorLabel = new Label();
            panel1 = new Panel();
            PlaylistsTEXT = new Label();
            SearchTextBoxPL = new TextBox();
            SearchBtnPL = new Button();
            PlaylistPanel.SuspendLayout();
            PlaylistBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlaylistPicBox).BeginInit();
            panel1.SuspendLayout();
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
            PlaylistPanel.Location = new Point(268, 68);
            PlaylistPanel.Margin = new Padding(3, 2, 3, 2);
            PlaylistPanel.Name = "PlaylistPanel";
            PlaylistPanel.Size = new Size(614, 403);
            PlaylistPanel.TabIndex = 2;
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
            SearchBtnPL.MouseEnter += SearchBtnPL_MouseEnter;
            SearchBtnPL.MouseLeave += SearchBtnPL_MouseLeave;
            // 
            // PlaylistsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(892, 481);
            Controls.Add(PlaylistsTEXT);
            Controls.Add(SearchBtnPL);
            Controls.Add(SearchTextBoxPL);
            Controls.Add(panel1);
            Controls.Add(PlaylistPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlaylistsForm";
            Text = "PLaylists";
            Load += Form2_Load;
            PlaylistPanel.ResumeLayout(false);
            PlaylistBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlaylistPicBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PlaylistFLP;
        private Panel PlaylistPanel;
        private PictureBox PlaylistPicBox;
        private Label PlaylistNameLabel;
        private Label PlaylistAuthorLabel;
        private Panel panel1;
        private Label PlaylistsTEXT;
        private TextBox SearchTextBoxPL;
        private Button SearchBtnPL;
        private GroupBox PlaylistBox;
        private Label PlaylistLengthLabel;
    }
}