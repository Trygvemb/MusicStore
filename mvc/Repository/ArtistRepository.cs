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
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        public ApplicationDbContext _context { get; }

        public ArtistRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<Artist> GetByIdAsync(int id)
        {
            return await _context.Artists.Include(a => a.Albums).FirstOrDefaultAsync(x => x.ArtistId == id);
        }
    }
}