using Music_App;

namespace TestStyle;

public partial class MainMenuForm : Form
{
    /// <summary>
    /// Constructor for the MainMenuForm class. Initializes the form and its components.
    /// </summary>
    public MainMenuForm()
    {
        InitializeComponent();
    }

    private void MainMenuForm_Load(object sender, EventArgs e)
    {
        searchBox.PlaceholderText = "Search for songs...";
    }

    private void signinButton_MouseEnter(object sender, EventArgs e)
    {
        signinButton.ForeColor = Color.BlueViolet;
    }

    private void signinButton_MouseLeave(object sender, EventArgs e)
    {
        signinButton.ForeColor = Color.FromArgb(255, 128, 0);
    }

    private void signinButton_Click(object sender, EventArgs e)
    {
        SigninForm signinForm = new SigninForm();
        signinForm.Show();
    }

    private void signupButton_MouseEnter(object sender, EventArgs e)
    {
        signupButton.ForeColor = Color.BlueViolet;
    }

    private void signupButton_MouseLeave(object sender, EventArgs e)
    {
        signupButton.ForeColor = Color.FromArgb(255, 128, 0);
    }

    private void signupButton_Click(object sender, EventArgs e)
    {
        SignupForm signupForm = new SignupForm();
        signupForm.Show();
    }

    private void songCreationButton_MouseEnter(object sender, EventArgs e)
    {
        songCreationButton.ForeColor = Color.FromArgb(0, 200, 80);
    }

    private void songCreationButton_MouseLeave(object sender, EventArgs e)
    {
        songCreationButton.ForeColor = Color.FromArgb(255, 128, 0);
    }

    private void songCreationButton_Click(object sender, EventArgs e)
    {
        // open song creation form
    }

    private void orderbyDateButton_MouseEnter(object sender, EventArgs e)
    {
        orderbyDateButton.ForeColor = Color.BlueViolet;
    }

    private void orderbyDateButton_MouseLeave(object sender, EventArgs e)
    {
        orderbyDateButton.ForeColor = Color.FromArgb(255, 128, 0);
    }

    private void orderbyDateButton_CheckedChanged(object sender, EventArgs e)
    {
        // order by date (or not)
    }

    private void orderbyPopularityButton_MouseEnter(object sender, EventArgs e)
    {
        orderbyPopularityButton.ForeColor = Color.BlueViolet;
    }

    private void orderbyPopularityButton_MouseLeave(object sender, EventArgs e)
    {
        orderbyPopularityButton.ForeColor = Color.FromArgb(255, 128, 0);
    }

    private void orderbyPopularityButton_CheckedChanged(object sender, EventArgs e)
    {
        // order by popularity (or not)
    }

    private void orderbyLengthButton_MouseEnter(object sender, EventArgs e)
    {
        orderbyLengthButton.ForeColor = Color.BlueViolet;
    }

    private void orderbyLengthButton_MouseLeave(object sender, EventArgs e)
    {
        orderbyLengthButton.ForeColor = Color.FromArgb(255, 128, 0);
    }

    private void orderbyLengthButton_CheckedChanged(object sender, EventArgs e)
    {
        // order by length (or not)
    }

    private void orderbyReverseBox_MouseEnter(object sender, EventArgs e)
    {
        orderbyReverseBox.ForeColor = Color.FromArgb(190, 190, 0);
    }

    private void orderbyReverseBox_MouseLeave(object sender, EventArgs e)
    {
        orderbyReverseBox.ForeColor = Color.FromArgb(255, 128, 0);
    }

    private void orderbyReverseBox_CheckedChanged(object sender, EventArgs e)
    {
        // order by reverse (or not)
    }

    private void searchBox_Validated(object sender, EventArgs e)
    {
        // search for songs (title and author)
    }

    private void songBox_Click(object sender, EventArgs e)
    {
        string title = "";
        string author = "";
        Image songImage = null;
        foreach (Control control in songBox.Controls)
        {
            if (control is Label label1 && label1.Name == "songTitleLabel")
            {
                title = label1.Text;
            }
            if (control is Label label2 && label2.Name == "songAuthorLabel")
            {
                author = label2.Text;
            }
            if (control is PictureBox pictureBox && pictureBox.Name == "songPictureBox")
            {
                songImage = pictureBox.Image;
            }
        }
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
        {
            MessageBox.Show("Song couldn't be opened");
            return;
        }
        SongMenu songMenuForm = new SongMenu(title, author, songImage);
        songMenuForm.Show();
    }
}
