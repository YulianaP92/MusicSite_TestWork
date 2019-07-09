using System.Collections.Generic;
using MusicSite.DAL.EF;
using MusicSite.DAL.Entities;
using MusicSite.DAL.Interfaces;

namespace MusicSite.DAL.Repositories
{
    public class SongRepository : IRepository<Song>
    {
        private readonly SongContext db;

        public SongRepository()
        {
            db = new SongContext();
        }
        public Song Get(int id)
        {
            return db.Songs.Find(id);
        }
        public IEnumerable<Song> GetAll()
        {
            return db.Songs;
        }
    }
}
