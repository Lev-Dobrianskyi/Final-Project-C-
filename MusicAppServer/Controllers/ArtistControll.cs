using Microsoft.EntityFrameworkCore;
using MusicAppServer.Data;
using MusicAppServer.Exceptions;
using MusicAppServer.Models;

namespace MusicAppServer.Controllers;

/// <summary>
/// Provides methods to manage artists in the music application, including adding, retrieving, removing, and updating artist information.
/// </summary>
public class ArtistController
{
    private readonly AppDBContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="ArtistController"/> class with a specified database context.
    /// </summary>
    /// <param name="context">The database context instance used to interact with the storage.</param>
    /// <exception cref="ArgumentNullException">Thrown when the provided <paramref name="context"/> is null.</exception>
    public ArtistController(AppDBContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Asynchronously adds a new artist to the database.
    /// </summary>
    /// <param name="artist">The artist entity to add.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="artist"/> is null.</exception>
    /// <exception cref="ArtistAlreadyExistsException">Thrown when an artist with the same name already exists in the system.</exception>
    /// <exception cref="DatabaseException">Thrown when an underlying database constraint is violated or a save error occurs.</exception>
    public async Task AddArtistAsync(Artist artist)
    {
        if (artist == null)
            throw new ArgumentNullException(nameof(artist));

        // Prevent duplicate artists by checking name uniqueness (case-insensitive)
        bool exists = await _context.Artists
            .AnyAsync(a => a.Name.ToLower() == artist.Name.ToLower());

        if (exists)
            throw new ArtistAlreadyExistsException();

        try
        {
            await _context.Artists.AddAsync(artist);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException("An error occurred while adding the artist to the database.", ex);
        }
    }

    /// <summary>
    /// Asynchronously retrieves an artist from the database by their unique identifier.
    /// </summary>
    /// <param name="artistId">The unique ID of the artist to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the retrieved <see cref="Artist"/>.</returns>
    /// <exception cref="ArtistNotFoundException">Thrown when no artist matches the specified <paramref name="artistId"/>.</exception>
    public async Task<Artist> GetArtistByIdAsync(int artistId)
    {
        var artist = await _context.Artists.FindAsync(artistId);

        if (artist == null)
            throw new ArtistNotFoundException();

        return artist;
    }

    /// <summary>
    /// Asynchronously removes an artist from the database by their unique identifier.
    /// </summary>
    /// <param name="artistId">The unique ID of the artist to remove.</param>
    /// <exception cref="ArtistNotFoundException">Thrown when no artist is found with the specified <paramref name="artistId"/>.</exception>
    /// <exception cref="DatabaseException">Thrown when a database failure occurs during record deletion.</exception>
    public async Task RemoveArtistAsync(int artistId)
    {
        var artist = await _context.Artists.FindAsync(artistId);

        if (artist == null)
            throw new ArtistNotFoundException();

        try
        {
            _context.Artists.Remove(artist);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to remove artist with ID {artistId} from the database.", ex);
        }
    }

    /// <summary>
    /// Asynchronously updates the name of an existing artist in the database.
    /// </summary>
    /// <param name="artistId">The unique identifier of the artist to be updated.</param>
    /// <param name="newName">The new name to assign to the artist.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="newName"/> is null, empty, or consists only of white-space characters.</exception>
    /// <exception cref="ArtistNotFoundException">Thrown when no artist matches the provided <paramref name="artistId"/>.</exception>
    /// <exception cref="ArtistAlreadyExistsException">Thrown when the <paramref name="newName"/> is already taken by another artist.</exception>
    /// <exception cref="DatabaseException">Thrown when a database conflict or save failure occurs during the update process.</exception>
    public async Task UpdateArtistNameAsync(int artistId, string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("New artist name cannot be null or empty.", nameof(newName));

        var artist = await _context.Artists.FindAsync(artistId);

        if (artist == null)
            throw new ArtistNotFoundException();

        // Validate that the new name won't conflict with another existing artist record
        bool nameExists = await _context.Artists
            .AnyAsync(a => a.Id != artistId && a.Name.ToLower() == newName.ToLower());

        if (nameExists)
            throw new ArtistAlreadyExistsException();

        try
        {
            artist.Name = newName;
            _context.Artists.Update(artist);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to update the name for artist ID {artistId}.", ex);
        }
    }
}