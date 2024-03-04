using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Artist>()
            // .HasMany(a => a.Albums)
            // .WithOne(a => a.Artist)
            // .HasForeignKey(a => a.AlbumId);

            // modelBuilder.Entity<Album>()
            // .HasMany(a => a.Songs)
            // .WithOne(s => s.Album)
            // .HasForeignKey(a => a.SongId);

            // modelBuilder.Entity<Genre>()
            // .HasMany(g => g.Albums)
            // .WithOne(g => g.Genre)
            // .HasForeignKey(a => a.AlbumId);

            modelBuilder.Entity<Song>()
            .HasMany(s => s.Playlists)
            .WithMany(p => p.Songs)
            .UsingEntity<Dictionary<string, object>>
            (
                "SongPlaylist",
                j => j.HasOne<Playlist>()
                .WithMany()
                .HasForeignKey("PlaylistId")
                .OnDelete(DeleteBehavior.Restrict),
                j => j
                .HasOne<Song>()
                .WithMany()
                .HasForeignKey("SongId")
                .OnDelete(DeleteBehavior.Restrict)
            );

            modelBuilder.Entity<Song>()
            .HasOne(s => s.Album)
            .WithMany(a => a.Songs)
            .HasForeignKey(s => s.AlbumId)
            .OnDelete(DeleteBehavior.NoAction);

        }
    }
}