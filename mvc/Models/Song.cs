using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string? Name { get; set; }
        public string? SongUrl { get; set; }
        public int AlbumId { get; set; }
        public Album? Album { get; set; }
        public ICollection<Playlist>? Playlists { get; set; }
    }
}