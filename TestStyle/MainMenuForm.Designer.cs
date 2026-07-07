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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            songPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            orderbyDateButton = new Button();
            orderbyPopularityButton = new Button();
            orderbyLengthButton = new Button();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            songPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 65);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Banner", 14F);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(793, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 3;
            label1.Text = "99:99";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Font = new Font("Sylfaen", 16F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(57, 15);
            label2.Name = "label2";
            label2.Size = new Size(492, 30);
            label2.TabIndex = 1;
            label2.Text = "Song Title";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 15);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Sitka Banner", 12F);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(57, 37);
            label3.Name = "label3";
            label3.Size = new Size(300, 21);
            label3.TabIndex = 2;
            label3.Text = "Song Author";
            // 
            // songPanel
            // 
            songPanel.AutoScroll = true;
            songPanel.Controls.Add(orderbyDateButton);
            songPanel.Controls.Add(orderbyPopularityButton);
            songPanel.Controls.Add(orderbyLengthButton);
            songPanel.Controls.Add(groupBox1);
            songPanel.Location = new Point(12, 89);
            songPanel.Name = "songPanel";
            songPanel.Size = new Size(860, 560);
            songPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(891, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 560);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 0;
            button1.Text = "Song creation";
            button1.UseVisualStyleBackColor = true;
            // 
            // orderbyDateButton
            // 
            orderbyDateButton.Location = new Point(3, 3);
            orderbyDateButton.Name = "orderbyDateButton";
            orderbyDateButton.Size = new Size(75, 23);
            orderbyDateButton.TabIndex = 5;
            orderbyDateButton.Text = "Date";
            orderbyDateButton.UseVisualStyleBackColor = true;
            // 
            // orderbyPopularityButton
            // 
            orderbyPopularityButton.Location = new Point(84, 3);
            orderbyPopularityButton.Name = "orderbyPopularityButton";
            orderbyPopularityButton.Size = new Size(75, 23);
            orderbyPopularityButton.TabIndex = 6;
            orderbyPopularityButton.Text = "Popularity";
            orderbyPopularityButton.UseVisualStyleBackColor = true;
            // 
            // orderbyLengthButton
            // 
            orderbyLengthButton.Location = new Point(165, 3);
            orderbyLengthButton.Name = "orderbyLengthButton";
            orderbyLengthButton.Size = new Size(75, 23);
            orderbyLengthButton.TabIndex = 7;
            orderbyLengthButton.Text = "Length";
            orderbyLengthButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(930, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1184, 661);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(songPanel);
            Controls.Add(signinButton);
            Controls.Add(signupButton);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            songPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button signupButton;
        private Button signinButton;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private FlowLayoutPanel songPanel;
        private Panel panel1;
        private Button orderbyDateButton;
        private Button orderbyPopularityButton;
        private Button orderbyLengthButton;
        private Button button1;
        private PictureBox pictureBox2;
    }
}