namespace MusicAppServer
{
    internal class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int GenreId { get; set; }
        public SongGenre Genre { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Artist> Artists { get; set; }
        public SongGenre genre { get; set; }
        public int genreId { get; set; }
    }
}
