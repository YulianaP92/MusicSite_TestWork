using System.Collections.Generic;

namespace MusicSite.BLL.DTO
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SongDto> SongsDto { get; set; }
    }
}
