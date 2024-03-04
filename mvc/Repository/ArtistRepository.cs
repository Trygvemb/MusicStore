using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        public Task AddAsync(Artist entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Artist>> GetAlAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Artist entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Artist entity)
        {
            throw new NotImplementedException();
        }
    }
}