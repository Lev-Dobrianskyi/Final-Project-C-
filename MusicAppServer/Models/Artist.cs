namespace MusicAppServer.Models;

/// <summary>
/// Represents an artist in the music application.
/// </summary>
public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Song> Songs { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Artist"/> class.
    /// </summary>
    public Artist()
    {
        // Initializing collections prevents NullReferenceException during runtime manipulation
        Songs = new HashSet<Song>();
    }
}
