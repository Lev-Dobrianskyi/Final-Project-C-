using System.Drawing.Drawing2D;

namespace Music_App;

public partial class SongMenu : Form
{
    public string songTitle;
    public string songAuthor; // use these two strings to find a song in the database, these are sent when a song is clicked

    /// <summary>
    /// Creates a new instance of the SongMenu form with the specified title and author.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    public SongMenu(string title, string author)
    {
        songTitle = title;
        songAuthor = author;
        InitializeComponent();
    }

    private void SongMenu_Load(object sender, EventArgs e)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, Play_PauseBtn.Width, Play_PauseBtn.Height);

        Play_PauseBtn.Region = new Region(path);
        SongTrackBar.TickStyle = TickStyle.None;

        int songTime = MaxSongTimeLabel.Text.Length;

        SongTrackBar.Maximum = songTime;
    }
    bool isPlaying = false;
    private void Play_PauseBtn_Click(object sender, EventArgs e)
    {
        if (!isPlaying)
        {
            Play_PauseBtn.Text = " ❚❚";
        }
        else
        {
            Play_PauseBtn.Text = " ▶";
        }

        isPlaying = !isPlaying;
    }
}
