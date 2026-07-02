namespace TestStyle
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();

            txtEmail.Padding = new Padding(10, 8, 10, 8);
            txtPassword.Padding = new Padding(10, 8, 10, 8);

            this.FormBorderStyle = FormBorderStyle.None;     // прибирає стандартну рамку
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(255, 180, 0);  // --- яскравіший оранжевий
            btnLogin.ForeColor = Color.Black;
            btnLogin.Size = new Size(btnLogin.Width + 4, btnLogin.Height + 4); // --- трохи збільшується
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Orange;                 // --- повертаємо початковий колір
            btnLogin.ForeColor = Color.Black;
            btnLogin.Size = new Size(btnLogin.Width - 4, btnLogin.Height - 4); // --- ресет

        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    }
}
