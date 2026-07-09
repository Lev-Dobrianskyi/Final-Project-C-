using Microsoft.AspNetCore.Identity;
using Music_App.Client_class;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Music_App;

public partial class SignupForm : Form
{
    /// <summary>
    /// Creates a new instance of the SignupForm class.
    /// </summary>
    public SignupForm()
    {
        InitializeComponent();

        this.MaximumSize = new Size(0, 0);           // знімає обмеження
        this.FormBorderStyle = FormBorderStyle.None;     // прибирає стандартну рамку

        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
    }

    private void SignupForm_Load(object sender, EventArgs e)
    {
        txtEmail.PlaceholderText = "Enter your Email";
        txtPassword.PlaceholderText = "Enter your password";
    }

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

    private void btnSignup_MouseEnter(object sender, EventArgs e)
    {
        btnSignup.BackColor = Color.FromArgb(255, 180, 0);
        btnSignup.ForeColor = Color.Black;
        btnSignup.Size = new Size(btnSignup.Width + 4, btnSignup.Height + 4);
    }

    private void btnSignup_MouseLeave(object sender, EventArgs e)
    {
        btnSignup.BackColor = Color.Orange;
        btnSignup.ForeColor = Color.Black;
        btnSignup.Size = new Size(btnSignup.Width - 4, btnSignup.Height - 4);
    }

    private async void btnSignup_Click(object sender, EventArgs e)
    {

        labelEmailMessage.Visible = false;
        labePasswordMessage.Visible = false;

        bool isValid = true;

        if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
        {
            labelEmailMessage.Text = "Enter a valid email";
            labelEmailMessage.Visible = true;
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
        {
            labePasswordMessage.Text = "Password must consist of atleast 6 symbols";
            labePasswordMessage.Visible = true;
            isValid = false;
        }



        if (isValid)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                labelConfirmPasswordMessage.Text = "You wrote incorrect psw";
                return;
            }
            // 1. Хешуємо та пакуємо в JSON
            var hasher = new PasswordHasher<string>();
            string hashedPassword = hasher.HashPassword("user_placeholder", txtPassword.Text);

            var request = new SignupRequestModel { Name = txtUsername.Text, Email = txtEmail.Text, Password = hashedPassword };
            byte[] requestBuffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(request));

            // 2. Підключаємось та відправляємо
            using TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync("127.0.0.1", 5000); // Краще асинхронно

            using NetworkStream stream = tcpClient.GetStream();
            await stream.WriteAsync(requestBuffer, 0, requestBuffer.Length);

            // 3. Читаємо відповідь у новий буфер
            byte[] responseBuffer = new byte[1024];
            int length = await stream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
            string response = Encoding.UTF8.GetString(responseBuffer, 0, length);

            if (response != "Approve")
            {
                MessageBox.Show("Registration failed: " + response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Registration is OK: " + response, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        // Скидаємо помилки
        labelUserMessage.Visible = false;
        labelEmailMessage.Visible = false;
        labePasswordMessage.Visible = false;
        labelConfirmPasswordMessage.Visible = false;

        txtUsername.BackColor = Color.FromArgb(30, 30, 30);
        txtEmail.BackColor = Color.FromArgb(30, 30, 30);
        txtPassword.BackColor = Color.FromArgb(30, 30, 30);
        txtConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);

        bool isValid = true;

        // Username
        if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text.Length > 24)
        {
            labelUserMessage.Text = "Username must be between 1 and 24 characters";
            labelUserMessage.Visible = true;
            txtUsername.BackColor = Color.FromArgb(80, 30, 30);
            isValid = false;
        }

        // Email
        if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
        {
            labelEmailMessage.Text = "Please enter a valid email address";
            labelEmailMessage.Visible = true;
            txtEmail.BackColor = Color.FromArgb(80, 30, 30);
            isValid = false;
        }

        // Password
        if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
        {
            labePasswordMessage.Text = "Password must be at least 6 characters";
            labePasswordMessage.Visible = true;
            txtPassword.BackColor = Color.FromArgb(80, 30, 30);
            isValid = false;
        }

        // Confirm Password
        if (txtPassword.Text != txtConfirmPassword.Text)
        {
            labelConfirmPasswordMessage.Text = "Passwords do not match";
            labelConfirmPasswordMessage.Visible = true;
            txtConfirmPassword.BackColor = Color.FromArgb(80, 30, 30);
            isValid = false;
        }

        if (isValid)
        {
            //OpenMainMenu();  <-- тут запуск
        }
    }


    private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        SigninForm login = new SigninForm();
        login.Show();
        this.Hide();
    }


    [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    private void lblLogin_Click(object sender, EventArgs e)
    {

    }

    private void llLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }
}
