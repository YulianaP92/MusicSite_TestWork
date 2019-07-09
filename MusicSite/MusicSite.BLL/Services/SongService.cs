using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MusicSite.BLL.DTO;
using MusicSite.BLL.Interfaces;
using MusicSite.DAL.EF;

namespace MusicSite.BLL.Services
{
    public class SongService : IService<SongDto>
    {
        private SongContext _db;
        public SongService(SongContext db)
        {
            _db = db;
        }
        public SongDto Get(int id)
        {
            var songDal = _db.Songs.Find(id);
            var result = Mapper.Map<SongDto>(songDal);
            return result;
        }

        public IEnumerable<SongDto> GetAll()
        {
            var allSongs = _db.Songs.ToList();
            var result = Mapper.Map<IEnumerable<SongDto>>(allSongs);
            return result;
        }
    }
}
