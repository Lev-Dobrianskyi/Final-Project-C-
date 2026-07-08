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
            orderbyDateButton = new Button();
            orderbyPopularityButton = new Button();
            orderbyLengthButton = new Button();
            panel1 = new Panel();
            button1 = new Button();
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
            signupButton.Location = new Point(1161, 16);
            signupButton.Margin = new Padding(3, 4, 3, 4);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(86, 33);
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
            signinButton.Location = new Point(1254, 16);
            signinButton.Margin = new Padding(3, 4, 3, 4);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(86, 33);
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
            groupBox1.Location = new Point(3, 43);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(976, 87);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Banner", 14F);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(906, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 37);
            label1.TabIndex = 3;
            label1.Text = "99:99";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Font = new Font("Sylfaen", 16F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(65, 20);
            label2.Name = "label2";
            label2.Size = new Size(562, 40);
            label2.TabIndex = 1;
            label2.Text = "Song Title";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(9, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 57);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Sitka Banner", 12F);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(65, 49);
            label3.Name = "label3";
            label3.Size = new Size(343, 28);
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
            songPanel.Location = new Point(14, 119);
            songPanel.Margin = new Padding(3, 4, 3, 4);
            songPanel.Name = "songPanel";
            songPanel.Size = new Size(983, 747);
            songPanel.TabIndex = 6;
            // 
            // orderbyDateButton
            // 
            orderbyDateButton.Location = new Point(3, 4);
            orderbyDateButton.Margin = new Padding(3, 4, 3, 4);
            orderbyDateButton.Name = "orderbyDateButton";
            orderbyDateButton.Size = new Size(86, 31);
            orderbyDateButton.TabIndex = 5;
            orderbyDateButton.Text = "Date";
            orderbyDateButton.UseVisualStyleBackColor = true;
            // 
            // orderbyPopularityButton
            // 
            orderbyPopularityButton.Location = new Point(95, 4);
            orderbyPopularityButton.Margin = new Padding(3, 4, 3, 4);
            orderbyPopularityButton.Name = "orderbyPopularityButton";
            orderbyPopularityButton.Size = new Size(86, 31);
            orderbyPopularityButton.TabIndex = 6;
            orderbyPopularityButton.Text = "Popularity";
            orderbyPopularityButton.UseVisualStyleBackColor = true;
            // 
            // orderbyLengthButton
            // 
            orderbyLengthButton.Location = new Point(187, 4);
            orderbyLengthButton.Margin = new Padding(3, 4, 3, 4);
            orderbyLengthButton.Name = "orderbyLengthButton";
            orderbyLengthButton.Size = new Size(86, 31);
            orderbyLengthButton.TabIndex = 7;
            orderbyLengthButton.Text = "Length";
            orderbyLengthButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1018, 119);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 747);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(181, 31);
            button1.TabIndex = 0;
            button1.Text = "Song creation";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1063, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1353, 881);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(songPanel);
            Controls.Add(signinButton);
            Controls.Add(signupButton);
            Margin = new Padding(3, 4, 3, 4);
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