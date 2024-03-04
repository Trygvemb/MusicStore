using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Data
{
public static class ApplicationDbContextSeed
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        // Add Genres
        modelBuilder.Entity<Genre>().HasData(
            new Genre { GenreId = 1, Name = "Rock", Description = "Rock music genre" },
            new Genre { GenreId = 2, Name = "Pop", Description = "Pop music genre" }
            // Add more genres as needed
        );

        // Add Artists
        modelBuilder.Entity<Artist>().HasData(
            new Artist { ArtistId = 1, Name = "Artist1" },
            new Artist { ArtistId = 2, Name = "Artist2" }
            // Add more artists as needed
        );

        // Add Albums
        modelBuilder.Entity<Album>().HasData(
            new Album { AlbumId = 1, Title = "Album1", ArtistId = 1, GenreId = 1, Price = 10.99 },
            new Album { AlbumId = 2, Title = "Album2", ArtistId = 2, GenreId = 2, Price = 12.99 }
            // Add more albums as needed
        );

        // Add Songs
        modelBuilder.Entity<Song>().HasData(
            new Song { SongId = 1, Name = "Song1", AlbumId = 1, SongUrl = "https://example.com/song1" },
            new Song { SongId = 2, Name = "Song2", AlbumId = 2, SongUrl = "https://example.com/song2" }
            // Add more songs as needed
        );

        // Add Playlists
        modelBuilder.Entity<Playlist>().HasData(
            new Playlist { PlaylistId = 1, Name = "Playlist1" }
            // Add more playlists as needed
        );
    }
}

}