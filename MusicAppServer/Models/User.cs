namespace MusicAppServer.Models;

/// <summary>
/// Represents a user account within the music streaming and social application.
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public ICollection<Song> FavoriteSongs { get; set; }
    public ICollection<User> Friends { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class.
    /// </summary>
    public User()
    {
        // Initializing collections guarantees they are never null when creating a new User instance
        FavoriteSongs = new HashSet<Song>();
        Friends = new HashSet<User>();
    }
}