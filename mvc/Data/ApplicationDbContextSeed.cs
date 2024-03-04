using System;
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
                new Genre { GenreId = 2, Name = "Pop", Description = "Pop music genre" },
                new Genre { GenreId = 3, Name = "Hip-Hop", Description = "Hip-Hop music genre" },
                new Genre { GenreId = 4, Name = "Jazz", Description = "Jazz music genre" },
                new Genre { GenreId = 5, Name = "Electronic", Description = "Electronic music genre" }
            );

            // Add Artists
            modelBuilder.Entity<Artist>().HasData(
                new Artist { ArtistId = 1, Name = "The Rolling Stones" },
                new Artist { ArtistId = 2, Name = "Michael Jackson" },
                new Artist { ArtistId = 3, Name = "Eminem" },
                new Artist { ArtistId = 4, Name = "Miles Davis" },
                new Artist { ArtistId = 5, Name = "Daft Punk" }
            );

            // Add Albums
            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumId = 1, Title = "Sticky Fingers", ArtistId = 1, GenreId = 1, Price = 19.99 },
                new Album { AlbumId = 2, Title = "Thriller", ArtistId = 2, GenreId = 2, Price = 24.99 },
                new Album { AlbumId = 3, Title = "The Marshall Mathers LP", ArtistId = 3, GenreId = 3, Price = 15.99 },
                new Album { AlbumId = 4, Title = "Kind of Blue", ArtistId = 4, GenreId = 4, Price = 29.99 },
                new Album { AlbumId = 5, Title = "Random Access Memories", ArtistId = 5, GenreId = 5, Price = 22.99 }
            );

// Add Songs
modelBuilder.Entity<Song>().HasData(
    // Songs for Album 1
    new Song { SongId = 1, Name = "Brown Sugar", AlbumId = 1, SongUrl = "https://example.com/brown-sugar" },
    new Song { SongId = 2, Name = "Wild Horses", AlbumId = 1, SongUrl = "https://example.com/wild-horses" },
    new Song { SongId = 3, Name = "Can't You Hear Me Knocking", AlbumId = 1, SongUrl = "https://example.com/cant-you-hear-me-knocking" },
    new Song { SongId = 4, Name = "Angie", AlbumId = 1, SongUrl = "https://example.com/angie" },
    new Song { SongId = 5, Name = "Dead Flowers", AlbumId = 1, SongUrl = "https://example.com/dead-flowers" },
    new Song { SongId = 6, Name = "Moonlight Mile", AlbumId = 1, SongUrl = "https://example.com/moonlight-mile" },
    new Song { SongId = 7, Name = "Bitch", AlbumId = 1, SongUrl = "https://example.com/bitch" },
    new Song { SongId = 8, Name = "Sway", AlbumId = 1, SongUrl = "https://example.com/sway" },
    new Song { SongId = 9, Name = "Dead Flowers", AlbumId = 1, SongUrl = "https://example.com/dead-flowers" },
    new Song { SongId = 10, Name = "Wild Horses (Acoustic Version)", AlbumId = 1, SongUrl = "https://example.com/wild-horses-acoustic" },

    // Songs for Album 2
    new Song { SongId = 11, Name = "Wanna Be Starting Something", AlbumId = 2, SongUrl = "https://example.com/wanna-be-startin-somethin" },
    new Song { SongId = 12, Name = "The Girl Is Mine", AlbumId = 2, SongUrl = "https://example.com/the-girl-is-mine" },
    new Song { SongId = 13, Name = "Thriller", AlbumId = 2, SongUrl = "https://example.com/thriller" },
    new Song { SongId = 14, Name = "Beat It", AlbumId = 2, SongUrl = "https://example.com/beat-it" },
    new Song { SongId = 15, Name = "Billie Jean", AlbumId = 2, SongUrl = "https://example.com/billie-jean" },
    new Song { SongId = 16, Name = "Human Nature", AlbumId = 2, SongUrl = "https://example.com/human-nature" },
    new Song { SongId = 17, Name = "P.Y.T. (Pretty Young Thing)", AlbumId = 2, SongUrl = "https://example.com/pyt" },
    new Song { SongId = 18, Name = "Thriller (Instrumental)", AlbumId = 2, SongUrl = "https://example.com/thriller-instrumental" },
    new Song { SongId = 19, Name = "Beat It (Extended Version)", AlbumId = 2, SongUrl = "https://example.com/beat-it-extended" },
    new Song { SongId = 20, Name = "Billie Jean (Live)", AlbumId = 2, SongUrl = "https://example.com/billie-jean-live" }

    // Add more songs for other albums
);


            // Add Playlists
            modelBuilder.Entity<Playlist>().HasData(
                new Playlist { PlaylistId = 1, Name = "Top Hits" },
                new Playlist { PlaylistId = 2, Name = "Chill Vibes" },
                new Playlist { PlaylistId = 3, Name = "Throwback Classics" },
                new Playlist { PlaylistId = 4, Name = "Jazz Essentials" },
                new Playlist { PlaylistId = 5, Name = "Electronic Beats" }
            );
        }
    }
}
