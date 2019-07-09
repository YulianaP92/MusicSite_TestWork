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
        public void Create(Song song)
        {
            db.Songs.Add(song);
            db.Entry(song).State = EntityState.Added;
            db.SaveChanges();
            
        }

        public void Delete(int id)
        {
            var song = db.Songs.Find(id);
            if (song != null)
                db.Songs.Remove(song);
            db.SaveChanges();
        }

        public Song Get(int id)
        {
            return db.Songs.Find(id);
        }

        public IEnumerable<Song> GetAll()
        {
            return db.Songs;
        }

        public void Update(Song songNew)
        {
            var modifiedSongInDb = db.Songs.Find(songNew.Id);
            if (modifiedSongInDb != null)
            {
                db.Entry(modifiedSongInDb).CurrentValues.SetValues(songNew);
                db.Entry(modifiedSongInDb).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
