namespace Music_App
{
    partial class SignupForm
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
            lblPasswordMessage = new Label();
            lblEmailMessage = new Label();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnSignup = new Button();
            labelPasword = new Label();
            labelEmail = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // lblPasswordMessage
            // 
            lblPasswordMessage.AutoSize = true;
            lblPasswordMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblPasswordMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblPasswordMessage.Location = new Point(54, 280);
            lblPasswordMessage.Name = "lblPasswordMessage";
            lblPasswordMessage.Size = new Size(110, 13);
            lblPasswordMessage.TabIndex = 46;
            lblPasswordMessage.Text = "passwordMessage";
            lblPasswordMessage.Visible = false;
            // 
            // lblEmailMessage
            // 
            lblEmailMessage.AutoSize = true;
            lblEmailMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblEmailMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblEmailMessage.Location = new Point(54, 182);
            lblEmailMessage.Name = "lblEmailMessage";
            lblEmailMessage.Size = new Size(86, 13);
            lblEmailMessage.TabIndex = 45;
            lblEmailMessage.Text = "emailMessage";
            lblEmailMessage.Visible = false;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(25, 25, 25);
            pnlTitleBar.Location = new Point(-3, -2);
            pnlTitleBar.Margin = new Padding(3, 2, 3, 2);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(214, 34);
            pnlTitleBar.TabIndex = 44;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            pnlTitleBar.MouseUp += pnlTitleBar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(20, 20, 20);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClose.ForeColor = Color.FromArgb(255, 128, 0);
            btnClose.Location = new Point(293, 2);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 30);
            btnClose.TabIndex = 43;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.FromArgb(20, 20, 20);
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMaximize.ForeColor = Color.FromArgb(255, 128, 0);
            btnMaximize.Location = new Point(253, 2);
            btnMaximize.Margin = new Padding(3, 2, 3, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(39, 30);
            btnMaximize.TabIndex = 42;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(20, 20, 20);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.FromArgb(255, 128, 0);
            btnMinimize.Location = new Point(213, 2);
            btnMinimize.Margin = new Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(39, 30);
            btnMinimize.TabIndex = 41;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(255, 128, 0);
            btnSignup.FlatAppearance.BorderColor = Color.FromArgb(37, 37, 37);
            btnSignup.FlatAppearance.BorderSize = 5;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = SystemColors.ActiveCaptionText;
            btnSignup.Location = new Point(91, 318);
            btnSignup.Margin = new Padding(3, 2, 3, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(175, 37);
            btnSignup.TabIndex = 40;
            btnSignup.Text = "SIGN UP";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            btnSignup.MouseEnter += btnSignup_MouseEnter;
            btnSignup.MouseLeave += btnSignup_MouseLeave;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPasword.ForeColor = Color.FromArgb(255, 128, 0);
            labelPasword.Location = new Point(82, 221);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(165, 21);
            labelPasword.TabIndex = 39;
            labelPasword.Text = "Enter your password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEmail.ForeColor = Color.FromArgb(255, 128, 0);
            labelEmail.Location = new Point(91, 126);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(136, 21);
            labelEmail.TabIndex = 38;
            labelEmail.Text = "Enter your email";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI Emoji", 10.8F);
            txtPassword.ForeColor = Color.FromArgb(255, 128, 0);
            txtPassword.Location = new Point(54, 253);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 27);
            txtPassword.TabIndex = 37;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 30, 30);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Emoji", 10.8F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(54, 155);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 27);
            txtEmail.TabIndex = 36;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 128, 0);
            lblLogin.Location = new Point(54, 42);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(245, 96);
            lblLogin.TabIndex = 35;
            lblLogin.Text = "Sign up";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(334, 430);
            Controls.Add(lblPasswordMessage);
            Controls.Add(lblEmailMessage);
            Controls.Add(pnlTitleBar);
            Controls.Add(btnClose);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnSignup);
            Controls.Add(labelPasword);
            Controls.Add(labelEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Name = "SignupForm";
            Text = "SignupForm";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPasswordMessage;
        private Label lblEmailMessage;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnSignup;
        private Label labelPasword;
        private Label labelEmail;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblLogin;
    }
}