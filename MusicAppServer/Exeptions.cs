using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppServer
{
    public abstract class MusicServiceException : Exception
    {
        protected MusicServiceException() { }

        protected MusicServiceException(string message)
            : base(message) { }

        protected MusicServiceException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    #region Authorization

    public class AuthenticationException : MusicServiceException
    {
        public AuthenticationException(string message = "Authentication failed.")
            : base(message) { }
    }

    public class InvalidCredentialsException : MusicServiceException
    {
        public InvalidCredentialsException(string message = "Invalid username or password.")
            : base(message) { }
    }

    public class UserBlockedException : MusicServiceException
    {
        public UserBlockedException(string message = "User is blocked.")
            : base(message) { }
    }

    public class UnauthorizedAccessExceptionEx : MusicServiceException
    {
        public UnauthorizedAccessExceptionEx(string message = "Access denied.")
            : base(message) { }
    }

    public class SessionExpiredException : MusicServiceException
    {
        public SessionExpiredException(string message = "Session expired.")
            : base(message) { }
    }

    #endregion

    #region Validation

    public class ValidationException : MusicServiceException
    {
        public ValidationException(string message)
            : base(message) { }
    }

    public class InvalidEmailException : ValidationException
    {
        public InvalidEmailException()
            : base("Email format is invalid.") { }
    }

    public class WeakPasswordException : ValidationException
    {
        public WeakPasswordException()
            : base("Password does not meet security requirements.") { }
    }

    public class PasswordMismatchException : ValidationException
    {
        public PasswordMismatchException()
            : base("Passwords do not match.") { }
    }

    public class RequiredFieldException : ValidationException
    {
        public RequiredFieldException(string field)
            : base($"{field} is required.") { }
    }

    #endregion

    #region User

    public class UserNotFoundException : MusicServiceException
    {
        public UserNotFoundException()
            : base("User not found.") { }
    }

    public class UserAlreadyExistsException : MusicServiceException
    {
        public UserAlreadyExistsException()
            : base("User already exists.") { }
    }

    public class EmailAlreadyExistsException : MusicServiceException
    {
        public EmailAlreadyExistsException()
            : base("Email already exists.") { }
    }

    public class UsernameAlreadyExistsException : MusicServiceException
    {
        public UsernameAlreadyExistsException()
            : base("Username already exists.") { }
    }

    #endregion

    #region Song

    public class SongNotFoundException : MusicServiceException
    {
        public SongNotFoundException()
            : base("Song not found.") { }
    }

    public class SongAlreadyExistsException : MusicServiceException
    {
        public SongAlreadyExistsException()
            : base("Song already exists.") { }
    }

    public class InvalidAudioFileException : MusicServiceException
    {
        public InvalidAudioFileException()
            : base("Invalid audio file.") { }
    }

    #endregion

    #region Artist

    public class ArtistNotFoundException : MusicServiceException
    {
        public ArtistNotFoundException()
            : base("Artist not found.") { }
    }

    public class ArtistAlreadyExistsException : MusicServiceException
    {
        public ArtistAlreadyExistsException()
            : base("Artist already exists.") { }
    }

    #endregion

    #region Album

    public class AlbumNotFoundException : MusicServiceException
    {
        public AlbumNotFoundException()
            : base("Album not found.") { }
    }

    public class AlbumAlreadyExistsException : MusicServiceException
    {
        public AlbumAlreadyExistsException()
            : base("Album already exists.") { }
    }

    #endregion

    #region Playlist

    public class PlaylistNotFoundException : MusicServiceException
    {
        public PlaylistNotFoundException()
            : base("Playlist not found.") { }
    }

    public class PlaylistAlreadyExistsException : MusicServiceException
    {
        public PlaylistAlreadyExistsException()
            : base("Playlist already exists.") { }
    }

    public class SongAlreadyInPlaylistException : MusicServiceException
    {
        public SongAlreadyInPlaylistException()
            : base("Song already exists in playlist.") { }
    }

    public class SongNotInPlaylistException : MusicServiceException
    {
        public SongNotInPlaylistException()
            : base("Song does not exist in playlist.") { }
    }

    #endregion

    #region File

    public class FileStorageException : MusicServiceException
    {
        public FileStorageException(string message)
            : base(message) { }
    }

    public class FileTooLargeException : MusicServiceException
    {
        public FileTooLargeException()
            : base("File is too large.") { }
    }

    public class FileNotFoundExceptionEx : MusicServiceException
    {
        public FileNotFoundExceptionEx()
            : base("File not found.") { }
    }

    public class UnsupportedFileFormatException : MusicServiceException
    {
        public UnsupportedFileFormatException()
            : base("Unsupported file format.") { }
    }

    #endregion

    #region Database

    public class DatabaseException : MusicServiceException
    {
        public DatabaseException(string message)
            : base(message) { }
    }

    public class EntityNotFoundException : MusicServiceException
    {
        public EntityNotFoundException(string entity)
            : base($"{entity} was not found.") { }
    }

    public class DuplicateEntityException : MusicServiceException
    {
        public DuplicateEntityException(string entity)
            : base($"{entity} already exists.") { }
    }

    public class ConcurrencyException : MusicServiceException
    {
        public ConcurrencyException()
            : base("The data has been modified by another user.") { }
    }

    #endregion

    #region Player

    public class PlayerException : MusicServiceException
    {
        public PlayerException(string message)
            : base(message) { }
    }

    public class PlaybackException : PlayerException
    {
        public PlaybackException()
            : base("Unable to play the selected track.") { }
    }

    public class EmptyQueueException : PlayerException
    {
        public EmptyQueueException()
            : base("Playback queue is empty.") { }
    }

    #endregion

    #region Search

    public class SearchException : MusicServiceException
    {
        public SearchException(string message)
            : base(message) { }
    }

    #endregion

    #region Statistics

    public class StatisticsException : MusicServiceException
    {
        public StatisticsException(string message)
            : base(message) { }
    }

    #endregion

    #region Generic

    public class ConfigurationException : MusicServiceException
    {
        public ConfigurationException(string message)
            : base(message) { }
    }

    public class OperationFailedException : MusicServiceException
    {
        public OperationFailedException(string message)
            : base(message) { }
    }

    public class ResourceNotFoundException : MusicServiceException
    {
        public ResourceNotFoundException(string message)
            : base(message) { }
    }

    #endregion
}
