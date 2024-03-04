using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Data;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Repository
{
    public class SongRepository : GenericRepository<Song>, ISongRepository
    {
        public SongRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}