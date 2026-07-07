namespace MusicAppServer
{
    internal class SongControll
    {
        public static Song GetSongById(int songId)
        {
            using (var context = new AppContext())
            {
                return context.Songs.Find(songId);
            }
        }
        public static void AddSong(Song song)
        {
            using (var context = new AppContext())
            {
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }
        public static void RemoveSong(int songId)
        {
            using (var context = new AppContext())
            {
                var song = context.Songs.Find(songId);
                if (song != null)
                {
                    context.Songs.Remove(song);
                    context.SaveChanges();
                }
            }
        }
        public static void UpdateSongName(Song song, string newName)
        {
            using (var context = new AppContext())
            {
                song.Name = newName;
                context.Songs.Update(song);
                context.SaveChanges();
            }
        }
    }
}
