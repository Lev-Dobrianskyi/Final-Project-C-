using System;

namespace MusicAppServer;

/// <summary>
/// The base abstract class for all exceptions thrown within the MusicApp service.
/// </summary>
public abstract class MusicServiceException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MusicServiceException"/> class.
    /// </summary>
    protected MusicServiceException() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="MusicServiceException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    protected MusicServiceException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="MusicServiceException"/> class with a specified error message 
    /// and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    protected MusicServiceException(string message, Exception? innerException)
        : base(message, innerException) { }
}

#region Authorization

/// <summary>
/// Exception thrown when a general authentication failure occurs.
/// </summary>
public class AuthenticationException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationException"/> class with a default or custom message.
    /// </summary>
    /// <param name="message">The authentication error message.</param>
    public AuthenticationException(string message = "Authentication failed.")
        : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationException"/> class with a specified message and inner exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public AuthenticationException(string message, Exception innerException)
        : base(message, innerException) { }
}

/// <summary>
/// Exception thrown when the provided username or password is incorrect.
/// </summary>
public class InvalidCredentialsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidCredentialsException"/> class.
    /// </summary>
    /// <param name="message">The invalid credentials error message.</param>
    public InvalidCredentialsException(string message = "Invalid username or password.")
        : base(message) { }
}

/// <summary>
/// Exception thrown when a blocked user attempts to authenticate or perform an action.
/// </summary>
public class UserBlockedException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserBlockedException"/> class.
    /// </summary>
    /// <param name="message">The user blocked error message.</param>
    public UserBlockedException(string message = "User is blocked.")
        : base(message) { }
}

/// <summary>
/// Exception thrown when a user does not have the required permissions to access a resource or operation.
/// </summary>
public class UnauthorizedAccessExceptionEx : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnauthorizedAccessExceptionEx"/> class.
    /// </summary>
    /// <param name="message">The access denied error message.</param>
    public UnauthorizedAccessExceptionEx(string message = "Access denied.")
        : base(message) { }
}

/// <summary>
/// Exception thrown when the user's authentication session has expired.
/// </summary>
public class SessionExpiredException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionExpiredException"/> class.
    /// </summary>
    /// <param name="message">The session expired error message.</param>
    public SessionExpiredException(string message = "Session expired.")
        : base(message) { }
}

#endregion

#region Validation

/// <summary>
/// Base exception thrown when data validation fails.
/// </summary>
public class ValidationException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The validation error message.</param>
    public ValidationException(string message)
        : base(message) { }
}

/// <summary>
/// Exception thrown when an email address format is invalid.
/// </summary>
public class InvalidEmailException : ValidationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidEmailException"/> class with a default message.
    /// </summary>
    public InvalidEmailException()
        : base("Email format is invalid.") { }
}

/// <summary>
/// Exception thrown when a password does not meet the system's security requirements.
/// </summary>
public class WeakPasswordException : ValidationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WeakPasswordException"/> class with a default message.
    /// </summary>
    public WeakPasswordException()
        : base("Password does not meet security requirements.") { }
}

/// <summary>
/// Exception thrown when a password confirmation does not match the original password.
/// </summary>
public class PasswordMismatchException : ValidationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordMismatchException"/> class with a default message.
    /// </summary>
    public PasswordMismatchException()
        : base("Passwords do not match.") { }
}

/// <summary>
/// Exception thrown when a required field is left empty or null.
/// </summary>
public class RequiredFieldException : ValidationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RequiredFieldException"/> class specifying the missing field.
    /// </summary>
    /// <param name="field">The name of the field that is required.</param>
    public RequiredFieldException(string field)
        : base($"{field} is required.") { }
}

#endregion

#region User

/// <summary>
/// Exception thrown when the requested user account cannot be found.
/// </summary>
public class UserNotFoundException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserNotFoundException"/> class with a default message.
    /// </summary>
    public UserNotFoundException()
        : base("User not found.") { }
}

/// <summary>
/// Exception thrown when attempting to register a user that already exists.
/// </summary>
public class UserAlreadyExistsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserAlreadyExistsException"/> class with a default message.
    /// </summary>
    public UserAlreadyExistsException()
        : base("User already exists.") { }
}

/// <summary>
/// Exception thrown when attempting to register an email address that is already in use.
/// </summary>
public class EmailAlreadyExistsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAlreadyExistsException"/> class with a default message.
    /// </summary>
    public EmailAlreadyExistsException()
        : base("Email already exists.") { }
}

/// <summary>
/// Exception thrown when attempting to register a username that is already taken.
/// </summary>
public class UsernameAlreadyExistsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UsernameAlreadyExistsException"/> class with a default message.
    /// </summary>
    public UsernameAlreadyExistsException()
        : base("Username already exists.") { }
}

#endregion

#region Song

/// <summary>
/// Exception thrown when a requested song track cannot be found.
/// </summary>
public class SongNotFoundException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SongNotFoundException"/> class with a default message.
    /// </summary>
    public SongNotFoundException()
        : base("Song not found.") { }
}

/// <summary>
/// Exception thrown when attempting to create a song that already exists.
/// </summary>
public class SongAlreadyExistsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SongAlreadyExistsException"/> class with a default message.
    /// </summary>
    public SongAlreadyExistsException()
        : base("Song already exists.") { }
}

/// <summary>
/// Exception thrown when an audio file is corrupted, unreadable, or invalid.
/// </summary>
public class InvalidAudioFileException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidAudioFileException"/> class with a default message.
    /// </summary>
    public InvalidAudioFileException()
        : base("Invalid audio file.") { }
}

#endregion

#region Artist

/// <summary>
/// Exception thrown when a requested artist record cannot be found.
/// </summary>
public class ArtistNotFoundException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArtistNotFoundException"/> class with a default message.
    /// </summary>
    public ArtistNotFoundException()
        : base("Artist not found.") { }
}

/// <summary>
/// Exception thrown when attempting to create an artist that already exists.
/// </summary>
public class ArtistAlreadyExistsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArtistAlreadyExistsException"/> class with a default message.
    /// </summary>
    public ArtistAlreadyExistsException()
        : base("Artist already exists.") { }
}

#endregion

#region Album

/// <summary>
/// Exception thrown when a requested music album cannot be found.
/// </summary>
public class AlbumNotFoundException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AlbumNotFoundException"/> class with a default message.
    /// </summary>
    public AlbumNotFoundException()
        : base("Album not found.") { }
}

/// <summary>
/// Exception thrown when attempting to create an album that already exists.
/// </summary>
public class AlbumAlreadyExistsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AlbumAlreadyExistsException"/> class with a default message.
    /// </summary>
    public AlbumAlreadyExistsException()
        : base("Album already exists.") { }
}

#endregion

#region Playlist

/// <summary>
/// Exception thrown when a requested playlist cannot be found.
/// </summary>
public class PlaylistNotFoundException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlaylistNotFoundException"/> class with a default message.
    /// </summary>
    public PlaylistNotFoundException()
        : base("Playlist not found.") { }
}

/// <summary>
/// Exception thrown when attempting to create a playlist with a duplicate name for the same user.
/// </summary>
public class PlaylistAlreadyExistsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlaylistAlreadyExistsException"/> class with a default message.
    /// </summary>
    public PlaylistAlreadyExistsException()
        : base("Playlist already exists.") { }
}

/// <summary>
/// Exception thrown when trying to add a song to a playlist where it is already present.
/// </summary>
public class SongAlreadyInPlaylistException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SongAlreadyInPlaylistException"/> class with a default message.
    /// </summary>
    public SongAlreadyInPlaylistException()
        : base("Song already exists in playlist.") { }
}

/// <summary>
/// Exception thrown when trying to remove or interact with a song that does not exist in the specified playlist.
/// </summary>
public class SongNotInPlaylistException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SongNotInPlaylistException"/> class with a default message.
    /// </summary>
    public SongNotInPlaylistException()
        : base("Song does not exist in playlist.") { }
}

#endregion

#region File

/// <summary>
/// Exception thrown when general file storage, upload, or retrieval operations fail.
/// </summary>
public class FileStorageException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FileStorageException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The file storage error message.</param>
    public FileStorageException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileStorageException"/> class with a specified message and inner exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public FileStorageException(string message, Exception innerException)
        : base(message, innerException) { }
}

/// <summary>
/// Exception thrown when an uploaded file exceeds the maximum allowed size.
/// </summary>
public class FileTooLargeException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FileTooLargeException"/> class with a default message.
    /// </summary>
    public FileTooLargeException()
        : base("File is too large.") { }
}

/// <summary>
/// Exception thrown when a physical or media file cannot be found in the storage directory.
/// </summary>
public class FileNotFoundExceptionEx : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FileNotFoundExceptionEx"/> class with a default message.
    /// </summary>
    public FileNotFoundExceptionEx()
        : base("File not found.") { }
}

/// <summary>
/// Exception thrown when a file format is not supported by the application.
/// </summary>
public class UnsupportedFileFormatException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnsupportedFileFormatException"/> class with a default message.
    /// </summary>
    public UnsupportedFileFormatException()
        : base("Unsupported file format.") { }
}

#endregion

#region Database

/// <summary>
/// Exception thrown when a critical database operation fails.
/// </summary>
public class DatabaseException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The database error message.</param>
    public DatabaseException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseException"/> class with a specified message and inner exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The inner exception thrown by the data access provider or ORM.</param>
    public DatabaseException(string message, Exception innerException)
        : base(message, innerException) { }
}

/// <summary>
/// Exception thrown when a specific database entity or record is not found.
/// </summary>
public class EntityNotFoundException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityNotFoundException"/> class specifying the name of the entity.
    /// </summary>
    /// <param name="entity">The name or type of the entity that was not found.</param>
    public EntityNotFoundException(string entity)
        : base($"{entity} was not found.") { }
}

/// <summary>
/// Exception thrown when a database unique constraint is violated by trying to insert a duplicate record.
/// </summary>
public class DuplicateEntityException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DuplicateEntityException"/> class specifying the name of the entity.
    /// </summary>
    /// <param name="entity">The name or type of the duplicate entity.</param>
    public DuplicateEntityException(string entity)
        : base($"{entity} already exists.") { }
}

/// <summary>
/// Exception thrown when a concurrency violation occurs, typically during optimistic locking updates.
/// </summary>
public class ConcurrencyException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConcurrencyException"/> class with a default message.
    /// </summary>
    public ConcurrencyException()
        : base("The data has been modified by another user.") { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcurrencyException"/> class with a specified message and inner exception.
    /// </summary>
    /// <param name="message">The concurrency violation error message.</param>
    /// <param name="innerException">The inner exception related to the data conflict.</param>
    public ConcurrencyException(string message, Exception innerException)
        : base(message, innerException) { }
}

#endregion

#region Player

/// <summary>
/// Base exception thrown when an error occurs within the audio media player context.
/// </summary>
public class PlayerException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlayerException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The audio player error message.</param>
    public PlayerException(string message)
        : base(message) { }
}

/// <summary>
/// Exception thrown when the media player fails to initialize or start playback of a selected track.
/// </summary>
public class PlaybackException : PlayerException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlaybackException"/> class with a default message.
    /// </summary>
    public PlaybackException()
        : base("Unable to play the selected track.") { }
}

/// <summary>
/// Exception thrown when an operation is performed on a playback queue that contains no tracks.
/// </summary>
public class EmptyQueueException : PlayerException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmptyQueueException"/> class with a default message.
    /// </summary>
    public EmptyQueueException()
        : base("Playback queue is empty.") { }
}

#endregion

#region Search

/// <summary>
/// Exception thrown when an error occurs during search queries, parsing, or indexation.
/// </summary>
public class SearchException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The search error message.</param>
    public SearchException(string message)
        : base(message) { }
}

#endregion

#region Statistics

/// <summary>
/// Exception thrown when an error occurs while processing, collecting, or aggregating system analytics and statistics.
/// </summary>
public class StatisticsException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StatisticsException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The statistics error message.</param>
    public StatisticsException(string message)
        : base(message) { }
}

#endregion

#region Generic

/// <summary>
/// Exception thrown when an error is detected in the application settings or configurations.
/// </summary>
public class ConfigurationException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The configuration error message.</param>
    public ConfigurationException(string message)
        : base(message) { }
}

/// <summary>
/// Exception thrown as a generic wrapper when an operation fails and no specific exception type applies.
/// </summary>
public class OperationFailedException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OperationFailedException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The operation failure message.</param>
    public OperationFailedException(string message)
        : base(message) { }
}

/// <summary>
/// Exception thrown when an external or abstract system resource cannot be found.
/// </summary>
public class ResourceNotFoundException : MusicServiceException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceNotFoundException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The resource not found message.</param>
    public ResourceNotFoundException(string message)
        : base(message) { }
}

#endregion