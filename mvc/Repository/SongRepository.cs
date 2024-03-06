using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Areas.Identity.Data;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Repository
{
    public class SongRepository : GenericRepository<Song>, ISongRepository
    {
        public ApplicationDbContext _context { get; }
        public SongRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }

        public override async Task<Song> GetByIdAsync(int id)
        {
            return await _context.Songs
            .Include(s => s.Album)
            .FirstOrDefaultAsync(s => s.SongId == id);
        }
    }
}