using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppServer
{
    internal class GenreControll
    {
        public static void AddGenre(SongGenre genre)
        {
            using (var context = new AppContext())
            {
                context.SongGenres.Add(genre);
                context.SaveChanges();
            }
        }
        public static void RemoveGenre(int genreId)
        {
            using (var context = new AppContext())
            {
                var genre = context.SongGenres.Find(genreId);
                if (genre != null)
                {
                    context.SongGenres.Remove(genre);
                    context.SaveChanges();
                }
            }
        }
        public static void UpdateGenreName(SongGenre genre, string newName)
        {
            using (var context = new AppContext())
            {
                genre.GenreName = newName;
                context.SongGenres.Update(genre);
                context.SaveChanges();
            }
        }
        public static SongGenre GetGenreById(int genreId)
        {
            using (var context = new AppContext())
            {
                return context.SongGenres.Find(genreId);
            }

        }
    }
}
