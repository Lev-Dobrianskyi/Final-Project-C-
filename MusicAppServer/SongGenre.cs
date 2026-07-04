using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppServer
{
    internal class SongGenre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public ICollection<Song> Songs { get; set; }
}}
