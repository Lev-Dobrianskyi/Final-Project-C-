namespace MusicAppServer.Models;

/// <summary>
/// Represents a musical genre category within the music application.
/// </summary>
public class SongGenre
{
    public int Id { get; set; }
    public string GenreName { get; set; } = string.Empty;
    public ICollection<Song> Songs { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SongGenre"/> class.
    /// </summary>
    public SongGenre()
    {
        // Initializing the collection prevents NullReferenceExceptions when manipulating relationships
        Songs = new HashSet<Song>();
    }
}