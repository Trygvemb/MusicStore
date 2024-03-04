using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        public string? AlbumArtUrl { get; set; }
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}