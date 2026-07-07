using Microsoft.EntityFrameworkCore;

namespace MusicAppServer;

/// <summary>
/// Provides administrative and authentication operations for managing users within the database.
/// </summary>
public class UserController
{
    private readonly AppContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserController"/> class with a specified database context.
    /// </summary>
    /// <param name="context">The database context instance used to interact with the storage.</param>
    /// <exception cref="ArgumentNullException">Thrown when the provided <paramref name="context"/> is null.</exception>
    public UserController(AppContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Asynchronously checks if a user exists in the system with the specified email address.
    /// </summary>
    /// <param name="email">The email address to verify during sign-up processes.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains <c>true</c> if the email exists; otherwise, <c>false</c>.</returns>
    public async Task<bool> IsUserExistsByEmailAsync(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        return await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
    }

    /// <summary>
    /// Asynchronously verifies whether a user exists with the matching email and password credentials.
    /// </summary>
    /// <param name="email">The account email address.</param>
    /// <param name="password">The raw or hashed account password.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains <c>true</c> if credentials match; otherwise, <c>false</c>.</returns>
    public async Task<bool> VerifyUserCredentialsAsync(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            return false;

        return await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower() && u.Password == password);
    }

    /// <summary>
    /// Asynchronously adds a new user account to the database.
    /// </summary>
    /// <param name="user">The user entity instance to register.</param>
    /// <exception cref="ArgumentNullException">Thrown when the provided <paramref name="user"/> is null.</exception>
    /// <exception cref="EmailAlreadyExistsException">Thrown when the email address is already taken.</exception>
    /// <exception cref="DatabaseException">Thrown when an underlying database failure occurs during registration.</exception>
    public async Task AddUserAsync(User user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user));

        if (await IsUserExistsByEmailAsync(user.Email))
            throw new EmailAlreadyExistsException();

        try
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException("Failed to add user to the database.", ex);
        }
    }

    /// <summary>
    /// Asynchronously retrieves a user entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user account.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the retrieved <see cref="User"/>.</returns>
    /// <exception cref="UserNotFoundException">Thrown when no user matches the provided <paramref name="id"/>.</exception>
    public async Task<User> GetUserByIdAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);

        if (user == null)
            throw new UserNotFoundException();

        return user;
    }

    /// <summary>
    /// Asynchronously updates the profile name of an existing user.
    /// </summary>
    /// <param name="userId">The unique identifier of the user to be updated.</param>
    /// <param name="newName">The new display name or username to assign.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="newName"/> is null or white-space.</exception>
    /// <exception cref="UserNotFoundException">Thrown when the user does not exist.</exception>
    /// <exception cref="DatabaseException">Thrown when database synchronization fails.</exception>
    public async Task UpdateUserNameAsync(int userId, string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("New name cannot be null or empty.", nameof(newName));

        var user = await _context.Users.FindAsync(userId);
        if (user == null)
            throw new UserNotFoundException();

        try
        {
            user.Name = newName;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to update username for user ID {userId}.", ex);
        }
    }

    /// <summary>
    /// Asynchronously updates the email address of an existing user after validating its uniqueness.
    /// </summary>
    /// <param name="userId">The unique identifier of the user to be updated.</param>
    /// <param name="newEmail">The new email address to associate with the account.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="newEmail"/> is null or white-space.</exception>
    /// <exception cref="UserNotFoundException">Thrown when the user does not exist.</exception>
    /// <exception cref="EmailAlreadyExistsException">Thrown when <paramref name="newEmail"/> is already registered by another account.</exception>
    /// <exception cref="DatabaseException">Thrown when database processing encounters an error.</exception>
    public async Task UpdateUserEmailAsync(int userId, string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail))
            throw new ArgumentException("New email cannot be null or empty.", nameof(newEmail));

        var user = await _context.Users.FindAsync(userId);
        if (user == null)
            throw new UserNotFoundException();

        // Check if anyone else is already using this email address
        bool emailConflict = await _context.Users.AnyAsync(u => u.Id != userId && u.Email.ToLower() == newEmail.ToLower());
        if (emailConflict)
            throw new EmailAlreadyExistsException();

        try
        {
            user.Email = newEmail;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to update email address for user ID {userId}.", ex);
        }
    }

    /// <summary>
    /// Asynchronously updates the password credentials for an existing user account.
    /// </summary>
    /// <param name="userId">The unique identifier of the user to be updated.</param>
    /// <param name="newPassword">The new password string (should be securely hashed outside this method).</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="newPassword"/> is null or white-space.</exception>
    /// <exception cref="UserNotFoundException">Thrown when the user does not exist.</exception>
    /// <exception cref="DatabaseException">Thrown when data persistence fails.</exception>
    public async Task UpdateUserPasswordAsync(int userId, string newPassword)
    {
        if (string.IsNullOrWhiteSpace(newPassword))
            throw new ArgumentException("New password cannot be null or empty.", nameof(newPassword));

        var user = await _context.Users.FindAsync(userId);
        if (user == null)
            throw new UserNotFoundException();

        try
        {
            user.Password = newPassword;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to update password credentials for user ID {userId}.", ex);
        }
    }

    /// <summary>
    /// Asynchronously removes a user account from the database by their unique identifier.
    /// </summary>
    /// <param name="userId">The unique identifier of the user to remove.</param>
    /// <exception cref="UserNotFoundException">Thrown when no user account matches the provided <paramref name="userId"/>.</exception>
    /// <exception cref="DatabaseException">Thrown when database deletion routine fails.</exception>
    public async Task RemoveUserAsync(int userId)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user == null)
            throw new UserNotFoundException();

        try
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new DatabaseException($"Failed to remove user account with ID {userId}.", ex);
        }
    }
}