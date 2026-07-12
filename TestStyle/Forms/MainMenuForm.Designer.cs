using MusicAppServer.Models;

namespace TestStyle
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            signupButton = new Button();
            signinButton = new Button();
            songPanel = new FlowLayoutPanel();
            songBox = new Panel();
            songGenreLabel = new Label();
            songPictureBox = new PictureBox();
            songLengthLabel = new Label();
            songAuthorLabel = new Label();
            songTitleLabel = new Label();
            label5 = new Label();
            orderbyPopularityButton = new RadioButton();
            orderbyLengthButton = new RadioButton();
            orderbyReverseBox = new CheckBox();
            sidePanel = new Panel();
            label4 = new Label();
            songCreationButton = new Button();
            profilePictureBox = new PictureBox();
            searchBox = new TextBox();
            songPanel.SuspendLayout();
            songBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songPictureBox).BeginInit();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.FromArgb(20, 20, 20);
            signupButton.Cursor = Cursors.Hand;
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.ForeColor = Color.FromArgb(255, 128, 0);
            signupButton.Location = new Point(1016, 12);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(75, 25);
            signupButton.TabIndex = 3;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            signupButton.MouseEnter += signupButton_MouseEnter;
            signupButton.MouseLeave += signupButton_MouseLeave;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.FromArgb(20, 20, 20);
            signinButton.Cursor = Cursors.Hand;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.ForeColor = Color.FromArgb(255, 128, 0);
            signinButton.Location = new Point(1097, 12);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(75, 25);
            signinButton.TabIndex = 5;
            signinButton.Text = "Sign in";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            signinButton.MouseEnter += signinButton_MouseEnter;
            signinButton.MouseLeave += signinButton_MouseLeave;
            // 
            // songPanel
            // 
            songPanel.AutoScroll = true;
            songPanel.Controls.Add(songBox);
            songPanel.Location = new Point(12, 89);
            songPanel.Name = "songPanel";
            songPanel.Size = new Size(860, 560);
            songPanel.TabIndex = 6;
            // 
            // songBox
            // 
            songBox.BorderStyle = BorderStyle.FixedSingle;
            songBox.Controls.Add(songGenreLabel);
            songBox.Controls.Add(songPictureBox);
            songBox.Controls.Add(songLengthLabel);
            songBox.Controls.Add(songAuthorLabel);
            songBox.Controls.Add(songTitleLabel);
            songBox.Cursor = Cursors.Hand;
            songBox.Location = new Point(3, 3);
            songBox.Name = "songBox";
            songBox.Size = new Size(854, 58);
            songBox.TabIndex = 1;
            songBox.Paint += songBox_Paint;
            // 
            // songGenreLabel
            // 
            songGenreLabel.Font = new Font("Sitka Banner", 12F);
            songGenreLabel.ForeColor = SystemColors.ControlDark;
            songGenreLabel.Location = new Point(363, 29);
            songGenreLabel.Name = "songGenreLabel";
            songGenreLabel.Size = new Size(300, 26);
            songGenreLabel.TabIndex = 9;
            songGenreLabel.Text = "Dance-Pop";
            // 
            // songPictureBox
            // 
            songPictureBox.BorderStyle = BorderStyle.FixedSingle;
            songPictureBox.Image = (Image)resources.GetObject("songPictureBox.Image");
            songPictureBox.Location = new Point(8, 8);
            songPictureBox.Margin = new Padding(3, 2, 3, 2);
            songPictureBox.Name = "songPictureBox";
            songPictureBox.Size = new Size(40, 40);
            songPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            songPictureBox.TabIndex = 5;
            songPictureBox.TabStop = false;
            // 
            // songLengthLabel
            // 
            songLengthLabel.Font = new Font("Sitka Banner", 14F);
            songLengthLabel.ForeColor = SystemColors.ControlDark;
            songLengthLabel.Location = new Point(793, 9);
            songLengthLabel.Name = "songLengthLabel";
            songLengthLabel.Size = new Size(54, 28);
            songLengthLabel.TabIndex = 8;
            songLengthLabel.Text = "2:56";
            // 
            // songAuthorLabel
            // 
            songAuthorLabel.Font = new Font("Sitka Banner", 12F);
            songAuthorLabel.ForeColor = SystemColors.ControlDark;
            songAuthorLabel.Location = new Point(57, 29);
            songAuthorLabel.Name = "songAuthorLabel";
            songAuthorLabel.Size = new Size(300, 26);
            songAuthorLabel.TabIndex = 7;
            songAuthorLabel.Text = "Sabrina Carpenter";
            // 
            // songTitleLabel
            // 
            songTitleLabel.AutoEllipsis = true;
            songTitleLabel.Font = new Font("Sylfaen", 16F);
            songTitleLabel.ForeColor = SystemColors.ButtonShadow;
            songTitleLabel.Location = new Point(57, 2);
            songTitleLabel.Name = "songTitleLabel";
            songTitleLabel.Size = new Size(492, 30);
            songTitleLabel.TabIndex = 6;
            songTitleLabel.Text = "Espresso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(16, 57);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 8;
            label5.Text = "Order by:";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // orderbyPopularityButton
            // 
            orderbyPopularityButton.Appearance = Appearance.Button;
            orderbyPopularityButton.AutoSize = true;
            orderbyPopularityButton.Cursor = Cursors.Hand;
            orderbyPopularityButton.FlatStyle = FlatStyle.Flat;
            orderbyPopularityButton.ForeColor = Color.FromArgb(255, 128, 0);
            orderbyPopularityButton.Location = new Point(116, 62);
            orderbyPopularityButton.Margin = new Padding(3, 4, 3, 4);
            orderbyPopularityButton.Name = "orderbyPopularityButton";
            orderbyPopularityButton.Size = new Size(51, 27);
            orderbyPopularityButton.TabIndex = 11;
            orderbyPopularityButton.TabStop = true;
            orderbyPopularityButton.Text = "Name";
            orderbyPopularityButton.UseVisualStyleBackColor = true;
            orderbyPopularityButton.CheckedChanged += orderbyPopularityButton_CheckedChanged;
            orderbyPopularityButton.MouseEnter += orderbyPopularityButton_MouseEnter;
            orderbyPopularityButton.MouseLeave += orderbyPopularityButton_MouseLeave;
            // 
            // orderbyLengthButton
            // 
            orderbyLengthButton.Appearance = Appearance.Button;
            orderbyLengthButton.AutoSize = true;
            orderbyLengthButton.Cursor = Cursors.Hand;
            orderbyLengthButton.FlatStyle = FlatStyle.Flat;
            orderbyLengthButton.ForeColor = Color.FromArgb(255, 128, 0);
            orderbyLengthButton.Location = new Point(173, 62);
            orderbyLengthButton.Margin = new Padding(3, 4, 3, 4);
            orderbyLengthButton.Name = "orderbyLengthButton";
            orderbyLengthButton.Size = new Size(50, 27);
            orderbyLengthButton.TabIndex = 12;
            orderbyLengthButton.TabStop = true;
            orderbyLengthButton.Text = "Genre";
            orderbyLengthButton.UseVisualStyleBackColor = true;
            orderbyLengthButton.CheckedChanged += orderbyLengthButton_CheckedChanged;
            orderbyLengthButton.MouseEnter += orderbyLengthButton_MouseEnter;
            orderbyLengthButton.MouseLeave += orderbyLengthButton_MouseLeave;
            // 
            // orderbyReverseBox
            // 
            orderbyReverseBox.Appearance = Appearance.Button;
            orderbyReverseBox.AutoSize = true;
            orderbyReverseBox.Cursor = Cursors.Hand;
            orderbyReverseBox.FlatStyle = FlatStyle.Flat;
            orderbyReverseBox.Font = new Font("Segoe UI", 9.5F);
            orderbyReverseBox.ForeColor = Color.FromArgb(255, 128, 0);
            orderbyReverseBox.Location = new Point(229, 62);
            orderbyReverseBox.Margin = new Padding(3, 4, 3, 4);
            orderbyReverseBox.Name = "orderbyReverseBox";
            orderbyReverseBox.Size = new Size(64, 27);
            orderbyReverseBox.TabIndex = 9;
            orderbyReverseBox.Text = "Reverse";
            orderbyReverseBox.UseVisualStyleBackColor = true;
            orderbyReverseBox.CheckedChanged += orderbyReverseBox_CheckedChanged;
            orderbyReverseBox.MouseEnter += orderbyReverseBox_MouseEnter;
            orderbyReverseBox.MouseLeave += orderbyReverseBox_MouseLeave;
            // 
            // sidePanel
            // 
            sidePanel.AutoScroll = true;
            sidePanel.Controls.Add(label4);
            sidePanel.Controls.Add(songCreationButton);
            sidePanel.Location = new Point(891, 89);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(281, 560);
            sidePanel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(7, 3);
            label4.Name = "label4";
            label4.Size = new Size(266, 30);
            label4.TabIndex = 1;
            label4.Text = "Want to become an artist?";
            // 
            // songCreationButton
            // 
            songCreationButton.BackColor = Color.FromArgb(20, 20, 20);
            songCreationButton.Cursor = Cursors.Hand;
            songCreationButton.FlatStyle = FlatStyle.Flat;
            songCreationButton.ForeColor = Color.FromArgb(255, 128, 0);
            songCreationButton.Location = new Point(65, 36);
            songCreationButton.Name = "songCreationButton";
            songCreationButton.Size = new Size(158, 25);
            songCreationButton.TabIndex = 0;
            songCreationButton.Text = "Create your song!";
            songCreationButton.UseVisualStyleBackColor = false;
            songCreationButton.Click += songCreationButton_Click;
            songCreationButton.MouseEnter += songCreationButton_MouseEnter;
            songCreationButton.MouseLeave += songCreationButton_MouseLeave;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BorderStyle = BorderStyle.FixedSingle;
            profilePictureBox.Image = (Image)resources.GetObject("profilePictureBox.Image");
            profilePictureBox.Location = new Point(1097, 11);
            profilePictureBox.Margin = new Padding(3, 2, 3, 2);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(75, 75);
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureBox.TabIndex = 8;
            profilePictureBox.TabStop = false;
            profilePictureBox.Visible = false;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(30, 30, 30);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(242, 22);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(535, 23);
            searchBox.TabIndex = 9;
            searchBox.Validated += searchBox_Validated;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1184, 661);
            Controls.Add(label5);
            Controls.Add(searchBox);
            Controls.Add(profilePictureBox);
            Controls.Add(orderbyPopularityButton);
            Controls.Add(signupButton);
            Controls.Add(orderbyLengthButton);
            Controls.Add(sidePanel);
            Controls.Add(orderbyReverseBox);
            Controls.Add(songPanel);
            Controls.Add(signinButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            songPanel.ResumeLayout(false);
            songBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)songPictureBox).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button signupButton;
        private Button signinButton;
        private FlowLayoutPanel songPanel;
        private Panel sidePanel;
        private Button songCreationButton;
        private PictureBox profilePictureBox;
        private Label label4;
        private Label label5;
        private CheckBox orderbyReverseBox;
        private RadioButton orderbyPopularityButton;
        private RadioButton orderbyLengthButton;
        private TextBox searchBox;
        private Panel songBox;
        private Label songGenreLabel;
        private PictureBox songPictureBox;
        private Label songLengthLabel;
        private Label songAuthorLabel;
        private Label songTitleLabel;
    }
}