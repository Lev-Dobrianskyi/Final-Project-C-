using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestStyle
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.MaximumSize = new Size(0, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));

        }

        //   ---------------- кнопи зверху --------------  //
        //close button
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //minimize button
        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.BlueViolet;
        }
        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.FromArgb(255, 128, 0);
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //btnMaximize button
        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.ForeColor = Color.Yellow;
        }
        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.ForeColor = Color.FromArgb(255, 128, 0);
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                (screen.Width - this.Width) / 2,
                (screen.Height - this.Height) / 2
            );
        }


        //   ---------------- перетягування форми --------------  //
        private bool isDragging = false;
        private Point lastCursorPos;

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = e.Location;
            }
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point current = PointToScreen(e.Location);
                this.Location = new Point(current.X - lastCursorPos.X, current.Y - lastCursorPos.Y);
            }
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }



        //=== ---> REGISTER <--- ===//
        //   ---------------- кнопка реєстрації --------------  //
        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(255, 180, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Size = new Size(btnRegister.Width + 4, btnRegister.Height + 4);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.Orange;
            btnRegister.ForeColor = Color.Black;
            btnRegister.Size = new Size(btnRegister.Width - 4, btnRegister.Height - 4);

        }

        //   ---------------- логіка кнопки реєстрації --------------  //
        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblEmailMessage.Visible = false;
            lblPasswordMessage.Visible = false;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@gmail.com"))
            {
                lblEmailMessage.Text = "Введіть коректну пошту";
                lblEmailMessage.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                lblPasswordMessage.Text = "Пароль повинен бути мінімум 6 символів";
                lblPasswordMessage.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                OpenMainMenu();
            }
        }

        //   -------------- відкриття головного меню ---------------  //
        private void OpenMainMenu()
        {
            MainMenuForm main = new MainMenuForm();
            main.Show();
            this.Hide();
        }
        //   ---------------- завантаження форми ---------------  //
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtEmail.PlaceholderText = "Введіть ваш email";
            txtPassword.PlaceholderText = "Введіть ваш пароль";
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    }



}
