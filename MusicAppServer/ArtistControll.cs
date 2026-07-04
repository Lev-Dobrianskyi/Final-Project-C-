using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppServer
{
    internal class ArtistControll
    {
        public static void AddArtist(Artist artist)
        {
            using (var context = new AppContext())
            {
                context.Artists.Add(artist);
                context.SaveChanges();
            }
        }
        public static Artist GetArtistById(int artistId)
        {
            using (var context = new AppContext())
            {
                return context.Artists.Find(artistId);
            }
        }
        public static void RemoveArtist(int artistId)
        {
            using (var context = new AppContext())
            {
                var artist = context.Artists.Find(artistId);
                if (artist != null)
                {
                    context.Artists.Remove(artist);
                    context.SaveChanges();
                }
            }
        }
        public static void UpdateArtistName(Artist artist, string newName)
        {
            using (var context = new AppContext())
            {
                artist.Name = newName;
                context.Artists.Update(artist);
                context.SaveChanges();
            }
        }
    }
}
