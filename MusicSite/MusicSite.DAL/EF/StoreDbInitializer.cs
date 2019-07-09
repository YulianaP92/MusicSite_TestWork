using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicSite.DAL.Entities;

namespace MusicSite.DAL.EF
{
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<SongContext>
    {
        protected override void Seed(SongContext db)
        {
            var author_1=new Author { Name = "Rammstein" };
            var author_2 = new Author { Name = "System of a Down" };
            var author_3 = new Author { Name = "Myles Kennedy" };
            var author_4 = new Author { Name = "Nirvana" };
            db.Authors.Add(author_1);
            db.Authors.Add(author_2);
            db.Authors.Add(author_3);
            db.Authors.Add(author_4);
            db.SaveChanges();
            db.Songs.Add(new Song { Name = "Deutschland",Author = author_1,Genre = "Rock", PostedOnSite = DateTime.Now});
            db.Songs.Add(new Song { Name = "Mutter", Author = author_1, Genre = "Rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Toxicity", Author = author_2, Genre = "Rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Aerials", Author = author_2, Genre = "Rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "30 Years to Life", Author = author_3, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Anastasia", Author = author_3, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Smells Like Teen Spirit", Author = author_4, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Lithium", Author = author_4, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.SaveChanges();
        }
    }
}
