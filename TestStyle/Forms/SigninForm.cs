using Music_App.Client_class;

namespace Music_App;

public partial class SigninForm : Form
{
    /// <summary>
    /// Creates a new instance of the SigninForm class.
    /// </summary>
    public SigninForm()
    {
        InitializeComponent();

        this.MaximumSize = new Size(0, 0);           // знімає обмеження
        this.FormBorderStyle = FormBorderStyle.None;     // прибирає стандартну рамку

        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
    }

    private void SigninForm_Load(object sender, EventArgs e)
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

    private void btnSignin_MouseEnter(object sender, EventArgs e)
    {
        btnSignin.BackColor = Color.FromArgb(255, 180, 0);
        btnSignin.ForeColor = Color.Black;
        btnSignin.Size = new Size(btnSignin.Width + 4, btnSignin.Height + 4);
    }

    private void btnSignin_MouseLeave(object sender, EventArgs e)
    {
        btnSignin.BackColor = Color.Orange;
        btnSignin.ForeColor = Color.Black;
        btnSignin.Size = new Size(btnSignin.Width - 4, btnSignin.Height - 4);
    }

    private void btnSignin_Click(object sender, EventArgs e)
    {
        labelEmailMessage.Visible = false;
        labelPasswordMessage.Visible = false;

        bool isValid = true;

        if (string.IsNullOrWhiteSpace(txtEmail.Text)) // or isnt found
        {
            labelEmailMessage.Text = "Default error message";
            labelEmailMessage.Visible = true;
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text)) // or isnt found
        {
            labelPasswordMessage.Text = "Default error message";
            labelPasswordMessage.Visible = true;
            isValid = false;
        }

        if (isValid)
        {
            this.Close();
        }
    }

    private void llSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        SignupForm signupForm = new SignupForm();
        signupForm.Show();
        this.Close();
    }

    [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    private void labelEmail_Click(object sender, EventArgs e)
    {

    }
}
