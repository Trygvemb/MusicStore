using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        public Task AddAsync(Album entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAlAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Album entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Album entity)
        {
            throw new NotImplementedException();
        }
    }
}