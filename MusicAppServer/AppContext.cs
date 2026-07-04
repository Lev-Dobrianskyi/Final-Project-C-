using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppServer
{
    internal class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongGenre> SongGenres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CourseSyst;Trusted_Connection=True;";//Write here
            optionsBuilder.UseSqlServer(connectionString);
        }
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
                .HasOne(s => s.genre)
                .WithMany(g => g.Songs)
                .HasForeignKey(s => s.GenreId)
                .OnDelete(DeleteBehavior.Cascade);
        





        }


    }
}
