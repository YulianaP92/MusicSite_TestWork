using System;

namespace MusicSite.BLL.DTO
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime? PostedOnSite { get; set; }
        public int? AuthorId { get; set; }
        public AuthorDto AuthorDto { get; set; }
    }
}
