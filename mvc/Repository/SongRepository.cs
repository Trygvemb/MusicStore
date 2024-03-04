using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Repository
{
    public class SongRepository : ISongRepository
    {
        public Task AddAsync(Song entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Song>> GetAlAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Song> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Song entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Song entity)
        {
            throw new NotImplementedException();
        }
    }
}