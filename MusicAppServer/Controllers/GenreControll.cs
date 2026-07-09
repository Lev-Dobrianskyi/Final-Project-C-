using Microsoft.EntityFrameworkCore;
using MusicAppServer.Exceptions;
using MusicAppServer.Models;
using MusicAppServer.Data;

namespace MusicAppServer.Controllers;

/// <summary>
/// Provides administrative operations for managing song genres within the database.
/// </summary>
public class GenreController
{
    private readonly AppDBContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="GenreController"/> class with a specified database context.
    /// </summary>
    /// <param name="context">The database context instance used to interact with the storage.</param>
    public GenreController(AppDBContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Asynchronously adds a new song genre to the system.
    /// </summary>
    /// <param name="genre">The song genre entity to be added.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="genre"/> is null.</exception>
    /// <exception cref="DuplicateEntityException">Thrown when a genre with the same name already exists.</exception>
    /// <exception cref="DatabaseException">Thrown when an error occurs while saving changes to the database.</exception>
    public async Task AddGenreAsync(SongGenre genre)
    {
        if (genre == null)
            throw new ArgumentNullException(nameof(genre));

        // Check if the genre name already exists to prevent duplicate entities
        bool exists = await _context.SongGenres
            .AnyAsync(g => g.GenreName.ToLower() == genre.GenreName.ToLower());

        if (exists)
            throw new DuplicateEntityException($"Genre '{genre.GenreName}'");

        try
        {
            await _context.SongGenres.AddAsync(genre);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException("Failed to add the new genre to the database.", ex);
        }
    }

    /// <summary>
    /// Asynchronously removes a song genre from the system by its unique identifier.
    /// </summary>
    /// <param name="genreId">The unique identifier of the genre to remove.</param>
    /// <exception cref="EntityNotFoundException">Thrown when no genre is found with the specified <paramref name="genreId"/>.</exception>
    /// <exception cref="DatabaseException">Thrown when an error occurs while deleting the record.</exception>
    public async Task RemoveGenreAsync(int genreId)
    {
        var genre = await _context.SongGenres.FindAsync(genreId);

        if (genre == null)
            throw new EntityNotFoundException($"Genre with ID {genreId}");

        try
        {
            _context.SongGenres.Remove(genre);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to remove genre with ID {genreId} from the database.", ex);
        }
    }

    /// <summary>
    /// Asynchronously updates the name of an existing song genre.
    /// </summary>
    /// <param name="genreId">The unique identifier of the genre to be updated.</param>
    /// <param name="newName">The new name to assign to the genre.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="newName"/> is null or empty.</exception>
    /// <exception cref="EntityNotFoundException">Thrown when no genre matches the provided <paramref name="genreId"/>.</exception>
    /// <exception cref="DuplicateEntityException">Thrown when the <paramref name="newName"/> is already taken by another genre.</exception>
    /// <exception cref="DatabaseException">Thrown when a database conflict or error occurs during update.</exception>
    public async Task UpdateGenreNameAsync(int genreId, string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("New genre name cannot be null or empty.", nameof(newName));

        var genre = await _context.SongGenres.FindAsync(genreId);
        if (genre == null)
            throw new EntityNotFoundException($"Genre with ID {genreId}");

        // Ensure the new name does not cause a collision with another existing genre
        bool nameExists = await _context.SongGenres
            .AnyAsync(g => g.Id != genreId && g.GenreName.ToLower() == newName.ToLower());

        if (nameExists)
            throw new DuplicateEntityException($"Genre '{newName}'");

        try
        {
            genre.GenreName = newName;
            _context.SongGenres.Update(genre);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to update the name for genre ID {genreId}.", ex);
        }
    }

    /// <summary>
    /// Asynchronously retrieves a song genre entity by its unique identifier.
    /// </summary>
    /// <param name="genreId">The unique identifier of the song genre.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the retrieved <see cref="SongGenre"/>.</returns>
    /// <exception cref="EntityNotFoundException">Thrown when no genre with the specified <paramref name="genreId"/> is found.</exception>
    public async Task<SongGenre> GetGenreByIdAsync(int genreId)
    {
        var genre = await _context.SongGenres.FindAsync(genreId);

        if (genre == null)
            throw new EntityNotFoundException($"Genre with ID {genreId}");

        return genre;
    }
}