using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicAppServer;

/// <summary>
/// Provides methods to manage songs in the music application, including adding, retrieving, removing, and updating song information.
/// </summary>
public class SongController
{
    private readonly AppContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="SongController"/> class with a specified database context.
    /// </summary>
    /// <param name="context">The database context instance used to interact with the storage.</param>
    /// <exception cref="ArgumentNullException">Thrown when the provided <paramref name="context"/> is null.</exception>
    public SongController(AppContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Asynchronously retrieves a song from the database by its unique identifier.
    /// </summary>
    /// <param name="songId">The unique ID of the song to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the retrieved <see cref="Song"/>.</returns>
    /// <exception cref="SongNotFoundException">Thrown when no song matches the specified <paramref name="songId"/>.</exception>
    public async Task<Song> GetSongByIdAsync(int songId)
    {
        var song = await _context.Songs.FindAsync(songId);

        if (song == null)
            throw new SongNotFoundException();

        return song;
    }

    /// <summary>
    /// Asynchronously adds a new song to the database.
    /// </summary>
    /// <param name="song">The song entity to add.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="song"/> is null.</exception>
    /// <exception cref="SongAlreadyExistsException">Thrown when a song with the same URL or name already exists in the system.</exception>
    /// <exception cref="DatabaseException">Thrown when an underlying database failure occurs during the operation.</exception>
    public async Task AddSongAsync(Song song)
    {
        if (song == null)
            throw new ArgumentNullException(nameof(song));

        // Prevent exact duplicates based on storage URL or track name constraints
        bool exists = await _context.Songs
            .AnyAsync(s => s.Url == song.Url || s.Name.ToLower() == song.Name.ToLower());

        if (exists)
            throw new SongAlreadyExistsException();

        try
        {
            await _context.Songs.AddAsync(song);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException("An error occurred while adding the song to the database.", ex);
        }
    }

    /// <summary>
    /// Asynchronously removes a song from the database by its unique identifier.
    /// </summary>
    /// <param name="songId">The unique ID of the song to remove.</param>
    /// <exception cref="SongNotFoundException">Thrown when no song is found with the specified <paramref name="songId"/>.</exception>
    /// <exception cref="DatabaseException">Thrown when a database failure occurs during record deletion.</exception>
    public async Task RemoveSongAsync(int songId)
    {
        var song = await _context.Songs.FindAsync(songId);

        if (song == null)
            throw new SongNotFoundException();

        try
        {
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to remove song with ID {songId} from the database.", ex);
        }
    }

    /// <summary>
    /// Asynchronously updates the title or name of an existing song.
    /// </summary>
    /// <param name="songId">The unique identifier of the song to be updated.</param>
    /// <param name="newName">The new name or title to assign to the song.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="newName"/> is null, empty, or consists only of white-space characters.</exception>
    /// <exception cref="SongNotFoundException">Thrown when no song matches the provided <paramref name="songId"/>.</exception>
    /// <exception cref="DatabaseException">Thrown when a database conflict or save failure occurs during the update process.</exception>
    public async Task UpdateSongNameAsync(int songId, string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("New song name cannot be null or empty.", nameof(newName));

        var song = await _context.Songs.FindAsync(songId);

        if (song == null)
            throw new SongNotFoundException();

        try
        {
            song.Name = newName;
            _context.Songs.Update(song);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to update the name for song ID {songId}.", ex);
        }
    }
}