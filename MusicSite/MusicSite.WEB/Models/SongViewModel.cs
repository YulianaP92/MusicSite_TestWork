using MusicSite.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicSite.WEB.Models
{
    public class SongViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime? PostedOnSite { get; set; }
        public int? AuthorId { get; set; }
        public  AuthorDto Author { get; set; }
    }
}