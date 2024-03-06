using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string? Name { get; set; }
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Song>? Songs { get; set; }
    }
}