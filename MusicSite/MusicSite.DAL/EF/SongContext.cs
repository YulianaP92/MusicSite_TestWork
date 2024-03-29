﻿using System.Data.Entity;
using MusicSite.DAL.Entities;

namespace MusicSite.DAL.EF
{
    public class SongContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Song> Songs { get; set; }
        public SongContext() : base("SongContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(p => p.Songs)
                .WithRequired(p => p.Author);
        }
    }
}
