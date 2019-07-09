using System;
using System.Data.Entity;
using MusicSite.DAL.Entities;

namespace MusicSite.DAL.EF
{
    public class StoreDbInitializer : DropCreateDatabaseAlways<SongContext>
    {
        protected override void Seed(SongContext db)
        {
            var author1 = new Author { Name = "Rammstein" };
            var author2 = new Author { Name = "System of a Down" };
            var author3 = new Author { Name = "Myles Kennedy" };
            var author4 = new Author { Name = "Nirvana" };
            db.Authors.Add(author1);
            db.Authors.Add(author2);
            db.Authors.Add(author3);
            db.Authors.Add(author4);
            db.SaveChanges();

            db.Songs.Add(new Song { Name = "Deutschland", Author = author1, Genre = "Rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Mutter", Author = author1, Genre = "Rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Toxicity", Author = author2, Genre = "Rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Aerials", Author = author2, Genre = "Rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "30 Years to Life", Author = author3, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Anastasia", Author = author3, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Smells Like Teen Spirit", Author = author4, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.Songs.Add(new Song { Name = "Lithium", Author = author4, Genre = "Melodic rock", PostedOnSite = DateTime.Now });
            db.SaveChanges();
        }
    }
}
