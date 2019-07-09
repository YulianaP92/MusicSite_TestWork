using System;

namespace MusicSite.DAL.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime? PostedOnSite { get; set; }
        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
