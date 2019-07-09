using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicSite.BLL.DTO;

namespace MusicSite.WEB.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<SongDto> SongsDto { get; set; }
    }
}