using Microsoft.EntityFrameworkCore;
using MusicAppServer.Models;

namespace MusicAppServer.Data;

/// <summary>
/// Represents the database context for the music application, providing access to the Users, Songs, SongGenres, and Artists tables.
/// </summary>
public class AppDBContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<SongGenre> SongGenres { get; set; }
    public DbSet<Artist> Artists { get; set; }

    /// <summary>
    /// Configures the database connection for the application context using SQL Server with a specified connection string.
    /// </summary>
    /// <param name="optionsBuilder">
    /// The options builder to configure the database connection.
    /// </param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CourseSyst;Trusted_Connection=True;";//Write here
        optionsBuilder.UseSqlServer(connectionString);
    }

    /// <summary>
    /// Configures the model relationships and constraints for the application context, including unique indexes and many-to-many relationships.
    /// </summary>
    /// <param name="modelBuilder">
    /// The model builder to configure the entity relationships and constraints.
    /// </param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
        modelBuilder.Entity<Song>()
            .HasIndex(s => s.Url)
            .IsUnique();
        modelBuilder.Entity<User>()
            .HasMany(u => u.Friends)
            .WithMany()
            .UsingEntity<Dictionary<string, object>>(
                "UserFriends",
                l => l.HasOne<User>().WithMany().HasForeignKey("FriendId"),
                r => r.HasOne<User>().WithMany().HasForeignKey("UserId")
            );
        modelBuilder.Entity<User>()
            .HasMany(u => u.FavoriteSongs)
            .WithMany(s => s.Users);

        modelBuilder.Entity<Song>()
            .HasMany(s => s.Artists)
            .WithMany(a => a.Songs);

        modelBuilder.Entity<Song>()
            .HasOne(s => s.Genre)
            .WithMany(g => g.Songs)
            .HasForeignKey(s => s.GenreId)
            .OnDelete(DeleteBehavior.Cascade);
    }

}
