namespace TestStyle
{
    partial class LoginForm
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
            lblLogin = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            labelEmail = new Label();
            labelPasword = new Label();
            btnLogin = new Button();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnlTitleBar = new Panel();
            lblEmailMessage = new Label();
            lblPasswordMessage = new Label();
            llRegister = new LinkLabel();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 128, 0);
            lblLogin.Location = new Point(72, 60);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(246, 105);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "Login";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 30, 30);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Emoji", 10.8F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(62, 207);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI Emoji", 10.8F);
            txtPassword.ForeColor = Color.FromArgb(255, 128, 0);
            txtPassword.Location = new Point(62, 337);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEmail.ForeColor = Color.FromArgb(255, 128, 0);
            labelEmail.Location = new Point(104, 168);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(169, 28);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "Enter your email";
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPasword.ForeColor = Color.FromArgb(255, 128, 0);
            labelPasword.Location = new Point(94, 295);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(206, 28);
            labelPasword.TabIndex = 13;
            labelPasword.Text = "Enter your password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(37, 37, 37);
            btnLogin.FlatAppearance.BorderSize = 5;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(104, 424);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 45);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(20, 20, 20);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.FromArgb(255, 128, 0);
            btnMinimize.Location = new Point(243, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 40);
            btnMinimize.TabIndex = 15;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.FromArgb(20, 20, 20);
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMaximize.ForeColor = Color.FromArgb(255, 128, 0);
            btnMaximize.Location = new Point(289, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 40);
            btnMaximize.TabIndex = 16;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(20, 20, 20);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClose.ForeColor = Color.FromArgb(255, 128, 0);
            btnClose.Location = new Point(335, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 40);
            btnClose.TabIndex = 17;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(25, 25, 25);
            pnlTitleBar.Location = new Point(-3, -3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(245, 45);
            pnlTitleBar.TabIndex = 18;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            pnlTitleBar.MouseUp += pnlTitleBar_MouseUp;
            // 
            // lblEmailMessage
            // 
            lblEmailMessage.AutoSize = true;
            lblEmailMessage.Font = new Font("Alef", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblEmailMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblEmailMessage.Location = new Point(62, 243);
            lblEmailMessage.Name = "lblEmailMessage";
            lblEmailMessage.Size = new Size(99, 18);
            lblEmailMessage.TabIndex = 19;
            lblEmailMessage.Text = "emailMessage";
            lblEmailMessage.Visible = false;
            lblEmailMessage.Click += lblEmailMessage_Click;
            // 
            // lblPasswordMessage
            // 
            lblPasswordMessage.AutoSize = true;
            lblPasswordMessage.Font = new Font("Alef", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblPasswordMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblPasswordMessage.Location = new Point(62, 373);
            lblPasswordMessage.Name = "lblPasswordMessage";
            lblPasswordMessage.Size = new Size(126, 18);
            lblPasswordMessage.TabIndex = 20;
            lblPasswordMessage.Text = "passwordMessage";
            lblPasswordMessage.Visible = false;
            // 
            // llRegister
            // 
            llRegister.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            llRegister.AutoSize = true;
            llRegister.Font = new Font("Sitka Text", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llRegister.LinkColor = Color.Yellow;
            llRegister.Location = new Point(12, 544);
            llRegister.Name = "llRegister";
            llRegister.Size = new Size(214, 19);
            llRegister.TabIndex = 21;
            llRegister.TabStop = true;
            llRegister.Text = "Немає акаунту? Зареєструйтеся";
            llRegister.LinkClicked += llRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            CancelButton = btnClose;
            ClientSize = new Size(382, 573);
            Controls.Add(llRegister);
            Controls.Add(lblPasswordMessage);
            Controls.Add(lblEmailMessage);
            Controls.Add(pnlTitleBar);
            Controls.Add(btnClose);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnLogin);
            Controls.Add(labelPasword);
            Controls.Add(labelEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label labelEmail;
        private Label labelPasword;
        private Button btnLogin;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Panel pnlTitleBar;
        private Label lblEmailMessage;
        private Label lblPasswordMessage;
        private LinkLabel llRegister;
    }
}