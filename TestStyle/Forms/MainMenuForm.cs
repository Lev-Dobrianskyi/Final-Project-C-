using Music_App;
using Music_App.Client_class;
using Music_App.Forms;
using MusicAppServer.Models;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

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
    private string orderByMode = "ASC"; // Default order by mode
    private string orderByField = "Name"; // Default order by field

    private async void GetSongsFromServer()
    {
        var request = new SongsRequestModel { OrderBy = orderByField, OrderDirection = orderByMode };
        byte[] requestBuffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(request));

        // 2. Підключаємось та відправляємо
        using TcpClient tcpClient = new TcpClient();
        await tcpClient.ConnectAsync("127.0.0.1", 5000); // Краще асинхронно

        using NetworkStream stream = tcpClient.GetStream();
        await stream.WriteAsync(requestBuffer, 0, requestBuffer.Length);

        // 3. Читаємо відповідь у новий буфер
        byte[] responseBuffer = new byte[1024];
        int length = await stream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
        string jsonResponse = Encoding.UTF8.GetString(responseBuffer, 0, length);

        using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
        {
            if (!doc.RootElement.TryGetProperty("Action", out JsonElement actionElement))
            {
                MessageBox.Show("Missing 'Action' property in request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (actionElement.GetString() == "songsResponse")
            {
                var messageModel = JsonSerializer.Deserialize<SongsResponseModel>(jsonResponse);
                var Sonds = messageModel.Songs;
                var SongToInfo = messageModel.SongsToInf;
                CreateSongBoxes(Sonds, SongToInfo);
            }
            else
            {
                MessageBox.Show($"Unexpected action: {actionElement.GetString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
    private void CreateSongBoxes(List<Song> songs, List<SongToInf> SongsToInf)
    {
        songPanel.Controls.Clear();

        foreach (Song song in songs)
        {
            var info = SongsToInf.FirstOrDefault(x => x.songId == song.Id);

            AddSongBox(song, info.Artists, info.Genres);
        }
    }
    private string FormatSecondsToTime(int totalSeconds)
    {
        if (totalSeconds <= 0) return "--:--";

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return $"{minutes}:{seconds:D2}";
    }
    private void AddSongBox(Song song, string artists, string genres)
    {
        Panel panel = new Panel();

        panel.BorderStyle = BorderStyle.FixedSingle;
        panel.Size = new Size(854, 58);
        panel.Cursor = Cursors.Hand;
        panel.Margin = new Padding(3, 3, 3, 3);

        PictureBox picture = new PictureBox();
        picture.Location = new Point(8, 8);
        picture.Size = new Size(40, 40);
        picture.SizeMode = PictureBoxSizeMode.StretchImage;
        picture.Image = songPictureBox.Image;

        Label title = new Label();
        title.Text = song.Name;
        title.Font = new Font("Sylfaen", 16);
        title.ForeColor = SystemColors.ButtonShadow;
        title.Location = new Point(57, 2);
        title.Size = new Size(492, 30);

        Label author = new Label();
        author.Text = artists;
        author.Font = new Font("Sitka Banner", 12);
        author.ForeColor = SystemColors.ControlDark;
        author.Location = new Point(57, 29);
        author.Size = new Size(300, 26);

        Label genre = new Label();
        genre.Text = genres;
        genre.Font = new Font("Sitka Banner", 12);
        genre.ForeColor = SystemColors.ControlDark;
        genre.Location = new Point(363, 29);
        genre.Size = new Size(300, 26);

        Label length = new Label();
        length.Text = FormatSecondsToTime(song.LengthInSeconds);
        length.Font = new Font("Sitka Banner", 14);
        length.ForeColor = SystemColors.ControlDark;
        length.Location = new Point(793, 9);
        length.Size = new Size(54, 28);

        panel.Controls.Add(picture);
        panel.Controls.Add(title);
        panel.Controls.Add(author);
        panel.Controls.Add(genre);
        panel.Controls.Add(length);

        panel.Tag = song;

        panel.Click += (s, e) => songBox_Click(s, e, artists);
        picture.Click += (s, e) => songBox_Click(s, e, artists);
        title.Click += (s, e) => songBox_Click(s, e, artists);
        author.Click += (s, e) => songBox_Click(s, e, artists);
        genre.Click += (s, e) => songBox_Click(s, e, artists);
        length.Click += (s, e) => songBox_Click(s, e, artists);

        songPanel.Controls.Add(panel);
    }
    private void MainMenuForm_Load(object sender, EventArgs e)
    {
        searchBox.PlaceholderText = "Search for songs...";
        GetSongsFromServer();
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
        if (orderbyPopularityButton.Checked) {
            orderByField = "Name";//live this field
            GetSongsFromServer();
        }
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
        if (orderbyLengthButton.Checked)
        {
            orderByField = "Genre";//live this field
            GetSongsFromServer();
        }
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
        orderByMode = orderbyReverseBox.Checked ? "DESC" : "ASC";

        GetSongsFromServer();
    }

    private void searchBox_Validated(object sender, EventArgs e)
    {
        // search for songs (title and author)
    }

    private void songBox_Click(object sender, EventArgs e, string artists)
    {
        Control control = sender as Control;

        Panel panel = control as Panel ?? control.Parent as Panel;

        if (panel == null)
            return;

        Song song = (Song)panel.Tag;

        SongMenu menu = new SongMenu(
            song,
            ((PictureBox)panel.Controls[0]).Image,
            artists);

        menu.Show();
    }

    private void songBox_Paint(object sender, PaintEventArgs e)
    {

    }
}
