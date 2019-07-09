using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MusicSite.BLL.DTO;
using MusicSite.BLL.Interfaces;
using MusicSite.DAL.EF;

namespace MusicSite.BLL.Services
{
    public class SongService : IService<SongDto>
    {
        private SongContext db;

        public SongService(SongContext db)
        {
            this.db = db;
        }
        public SongDto Get(int id)
        {
            var songDal = db.Songs.Find(id);
            var result = Mapper.Map<SongDto>(songDal);
            return result;
        }

        public IEnumerable<SongDto> GetAll()
        {
            var allSongs = db.Songs.ToList();
            var result = Mapper.Map<IEnumerable<SongDto>>(allSongs);
            return result;
        }
    }
}
