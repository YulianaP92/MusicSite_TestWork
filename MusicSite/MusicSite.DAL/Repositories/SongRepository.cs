using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicSite.DAL.EF;
using MusicSite.DAL.Entities;
using MusicSite.DAL.Interfaces;

namespace MusicSite.DAL.Repositories
{
    public class SongRepository : IDisposable, IRepository<Song>
    {
        private readonly SongContext db=new SongContext(); 
        public void Create(Song item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Song Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Song> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Song item)
        {
            throw new NotImplementedException();
        }
    }
}
