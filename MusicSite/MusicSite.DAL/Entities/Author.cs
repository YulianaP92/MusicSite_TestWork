using System.Collections.Generic;

namespace MusicSite.DAL.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Song> Songs { get; set; }
    }
}
