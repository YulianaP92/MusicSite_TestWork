using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
           
        }

        public IEnumerable<SongDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
