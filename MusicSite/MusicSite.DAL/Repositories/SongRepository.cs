using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicSite.DAL.EF;
using MusicSite.DAL.Entities;
using MusicSite.DAL.Interfaces;

namespace MusicSite.DAL.Repositories
{
    public class SongRepository : IRepository<Song>
    {
        private SongContext db;

        public SongRepository(SongContext db)
        {
            this.db = db;
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
