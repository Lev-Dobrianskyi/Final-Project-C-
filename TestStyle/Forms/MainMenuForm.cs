using Music_App;
using Music_App.Forms;
using MusicAppServer.Models;

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


    /**
    // 
    // songPanel
    // 
    songPanel.AutoScroll = true;
    songPanel.Controls.Add(songBox);
    songPanel.Location = new Point(14, 119);
    songPanel.Margin = new Padding(3, 4, 3, 4);
    songPanel.Name = "songPanel";
    songPanel.Size = new Size(983, 747);
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
    songBox.Location = new Point(3, 4);
    songBox.Margin = new Padding(3, 4, 3, 4);
    songBox.Name = "songBox";
    songBox.Size = new Size(976, 77);
    songBox.TabIndex = 1;
    songBox.Click += songBox_Click;
    // 
    // songGenreLabel
    // 
    songGenreLabel.Font = new Font("Sitka Banner", 12F);
    songGenreLabel.ForeColor = SystemColors.ControlDark;
    songGenreLabel.Location = new Point(415, 39);
    songGenreLabel.Name = "songGenreLabel";
    songGenreLabel.Size = new Size(343, 35);
    songGenreLabel.TabIndex = 9;
    songGenreLabel.Text = "Dance-Pop";
    // 
    // songPictureBox
    // 
    songPictureBox.Image = (Image)resources.GetObject("songPictureBox.Image");
    songPictureBox.Location = new Point(7, 9);
    songPictureBox.Margin = new Padding(3, 2, 3, 2);
    songPictureBox.Name = "songPictureBox";
    songPictureBox.Size = new Size(45, 38);
    songPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
    songPictureBox.TabIndex = 5;
    songPictureBox.TabStop = false;
    // 
    // songLengthLabel
    // 
    songLengthLabel.Font = new Font("Sitka Banner", 14F);
    songLengthLabel.ForeColor = SystemColors.ControlDark;
    songLengthLabel.Location = new Point(906, 12);
    songLengthLabel.Name = "songLengthLabel";
    songLengthLabel.Size = new Size(62, 37);
    songLengthLabel.TabIndex = 8;
    songLengthLabel.Text = "2:56";
    // 
    // songAuthorLabel
    // 
    songAuthorLabel.Font = new Font("Sitka Banner", 12F);
    songAuthorLabel.ForeColor = SystemColors.ControlDark;
    songAuthorLabel.Location = new Point(65, 39);
    songAuthorLabel.Name = "songAuthorLabel";
    songAuthorLabel.Size = new Size(343, 35);
    songAuthorLabel.TabIndex = 7;
    songAuthorLabel.Text = "Sabrina Carpenter";
    // 
    // songTitleLabel
    // 
    songTitleLabel.AutoEllipsis = true;
    songTitleLabel.Font = new Font("Sylfaen", 16F);
    songTitleLabel.ForeColor = SystemColors.ButtonShadow;
    songTitleLabel.Location = new Point(65, 3);
    songTitleLabel.Name = "songTitleLabel";
    songTitleLabel.Size = new Size(562, 40);
    songTitleLabel.TabIndex = 6;
    songTitleLabel.Text = "Espresso";
    Its base create song item and add it to the songPanel. 
        

**/
    private string GetAuthor(Song song)
    {
        switch (song.Name)
        {
            case "Espresso":
                return "Sabrina Carpenter";

            case "67 Six Seven":
                return "Gazan";

            default:
                return "Unknown";
        }
    }
    private string GetSongLength(Song song)
    {
        switch (song.Name)
        {
            case "Espresso":
                return "2:56";

            case "67 Six Seven":
                return "1:23";

            default:
                return "--:--";
        }
    }
    private void CreateSongBoxes()
    {
        songPanel.Controls.Clear();

        string serverSongs = Path.GetFullPath(
            Path.Combine(AppContext.BaseDirectory,
            @"..\..\..\..\MusicAppServer\Songs"));

        string[] files = Directory.GetFiles(serverSongs, "*.mp3");

        foreach (string file in files)
        {
            Song song = new Song();

            string fileName = Path.GetFileName(file);

            if (fileName == "sabrina-carpenter-espresso.mp3")
            {
                song.Name = "Espresso";
                song.Url = file;

                song.Genre = new SongGenre()
                {
                    GenreName = "Dance-Pop"
                };
            }
            else if (fileName == "Gazan_-_67_Six_Seven_(Sam_pisav).mp3")
            {
                song.Name = "67 Six Seven";
                song.Url = file;

                song.Genre = new SongGenre()
                {
                    GenreName = "Prank-Song"
                };
            }
            else
            {
                continue;
            }

            AddSongBox(song);
        }
    }
    private void AddSongBox(Song song)
    {
        Panel panel = new Panel();

        panel.BorderStyle = BorderStyle.FixedSingle;
        panel.Size = new Size(976, 77);
        panel.Cursor = Cursors.Hand;
        panel.Margin = new Padding(3, 4, 3, 4);

        PictureBox picture = new PictureBox();
        picture.Location = new Point(7, 9);
        picture.Size = new Size(45, 38);
        picture.SizeMode = PictureBoxSizeMode.StretchImage;
        picture.Image = songPictureBox.Image;

        Label title = new Label();
        title.Text = song.Name;
        title.Font = new Font("Sylfaen", 16);
        title.ForeColor = SystemColors.ButtonShadow;
        title.Location = new Point(65, 3);
        title.Size = new Size(562, 40);

        Label author = new Label();
        author.Text = GetAuthor(song);
        author.Font = new Font("Sitka Banner", 12);
        author.ForeColor = SystemColors.ControlDark;
        author.Location = new Point(65, 39);
        author.Size = new Size(343, 35);

        Label genre = new Label();
        genre.Text = song.Genre?.GenreName ?? "";
        genre.Font = new Font("Sitka Banner", 12);
        genre.ForeColor = SystemColors.ControlDark;
        genre.Location = new Point(415, 39);
        genre.Size = new Size(343, 35);

        Label length = new Label();
        length.Text = GetSongLength(song);
        length.Font = new Font("Sitka Banner", 14);
        length.ForeColor = SystemColors.ControlDark;
        length.Location = new Point(906, 12);
        length.Size = new Size(62, 37);

        panel.Controls.Add(picture);
        panel.Controls.Add(title);
        panel.Controls.Add(author);
        panel.Controls.Add(genre);
        panel.Controls.Add(length);

        panel.Tag = song;

        panel.Click += songBox_Click;
        picture.Click += songBox_Click;
        title.Click += songBox_Click;
        author.Click += songBox_Click;
        genre.Click += songBox_Click;
        length.Click += songBox_Click;

        songPanel.Controls.Add(panel);
    }
    private void MainMenuForm_Load(object sender, EventArgs e)
    {
        searchBox.PlaceholderText = "Search for songs...";
        CreateSongBoxes();
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
        SongCreationForm creationForm = new SongCreationForm();
        creationForm.ShowDialog();
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
        Control control = sender as Control;

        Panel panel = control as Panel ?? control.Parent as Panel;

        if (panel == null)
            return;

        Song song = (Song)panel.Tag;

        SongMenu menu = new SongMenu(
            song,
            ((PictureBox)panel.Controls[0]).Image);

        menu.Show();
    }
}
