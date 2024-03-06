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
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public ApplicationDbContext _context { get; }
        public AlbumRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        
        public override async Task<Album> GetByIdAsync(int id)
        {
            return await _context.Albums.Include(a => a.Songs).FirstOrDefaultAsync(x => x.AlbumId == id);
        }

    }
}