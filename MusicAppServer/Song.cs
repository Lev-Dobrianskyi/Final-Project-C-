namespace MusicAppServer;

/// <summary>
/// Represents a song entity within the music streaming system.
/// </summary>
public class Song
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public int GenreId { get; set; }
    public SongGenre? Genre { get; set; }
    public ICollection<User> Users { get; set; }
    public ICollection<Artist> Artists { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Song"/> class.
    /// </summary>
    public Song()
    {
        // Initializing collections prevents NullReferenceException during runtime manipulation
        Users = new HashSet<User>();
        Artists = new HashSet<Artist>();
    }
}
