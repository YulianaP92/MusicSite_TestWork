using System.Collections.Generic;
using MusicSite.BLL.DTO;

namespace MusicSite.WEB.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<SongDto> Songs { get; set; }
    }
}