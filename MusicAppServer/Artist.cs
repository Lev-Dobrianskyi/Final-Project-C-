using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppServer
{
    internal class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
