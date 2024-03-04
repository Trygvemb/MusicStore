﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc.Data;

#nullable disable

namespace mvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240304120839_SeedDataWithNames")]
    partial class SeedDataWithNames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SongPlaylist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("SongPlaylist");
                });

            modelBuilder.Entity("mvc.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"));

                    b.Property<string>("AlbumArtUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            ArtistId = 1,
                            GenreId = 1,
                            Price = 19.989999999999998,
                            Title = "Sticky Fingers"
                        },
                        new
                        {
                            AlbumId = 2,
                            ArtistId = 2,
                            GenreId = 2,
                            Price = 24.989999999999998,
                            Title = "Thriller"
                        },
                        new
                        {
                            AlbumId = 3,
                            ArtistId = 3,
                            GenreId = 3,
                            Price = 15.99,
                            Title = "The Marshall Mathers LP"
                        },
                        new
                        {
                            AlbumId = 4,
                            ArtistId = 4,
                            GenreId = 4,
                            Price = 29.989999999999998,
                            Title = "Kind of Blue"
                        },
                        new
                        {
                            AlbumId = 5,
                            ArtistId = 5,
                            GenreId = 5,
                            Price = 22.989999999999998,
                            Title = "Random Access Memories"
                        });
                });

            modelBuilder.Entity("mvc.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            Name = "The Rolling Stones"
                        },
                        new
                        {
                            ArtistId = 2,
                            Name = "Michael Jackson"
                        },
                        new
                        {
                            ArtistId = 3,
                            Name = "Eminem"
                        },
                        new
                        {
                            ArtistId = 4,
                            Name = "Miles Davis"
                        },
                        new
                        {
                            ArtistId = 5,
                            Name = "Daft Punk"
                        });
                });

            modelBuilder.Entity("mvc.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Description = "Rock music genre",
                            Name = "Rock"
                        },
                        new
                        {
                            GenreId = 2,
                            Description = "Pop music genre",
                            Name = "Pop"
                        },
                        new
                        {
                            GenreId = 3,
                            Description = "Hip-Hop music genre",
                            Name = "Hip-Hop"
                        },
                        new
                        {
                            GenreId = 4,
                            Description = "Jazz music genre",
                            Name = "Jazz"
                        },
                        new
                        {
                            GenreId = 5,
                            Description = "Electronic music genre",
                            Name = "Electronic"
                        });
                });

            modelBuilder.Entity("mvc.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaylistId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            PlaylistId = 1,
                            Name = "Top Hits"
                        },
                        new
                        {
                            PlaylistId = 2,
                            Name = "Chill Vibes"
                        },
                        new
                        {
                            PlaylistId = 3,
                            Name = "Throwback Classics"
                        },
                        new
                        {
                            PlaylistId = 4,
                            Name = "Jazz Essentials"
                        },
                        new
                        {
                            PlaylistId = 5,
                            Name = "Electronic Beats"
                        });
                });

            modelBuilder.Entity("mvc.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            AlbumId = 1,
                            Name = "Brown Sugar",
                            SongUrl = "https://example.com/brown-sugar"
                        },
                        new
                        {
                            SongId = 2,
                            AlbumId = 1,
                            Name = "Wild Horses",
                            SongUrl = "https://example.com/wild-horses"
                        },
                        new
                        {
                            SongId = 3,
                            AlbumId = 1,
                            Name = "Can't You Hear Me Knocking",
                            SongUrl = "https://example.com/cant-you-hear-me-knocking"
                        },
                        new
                        {
                            SongId = 4,
                            AlbumId = 1,
                            Name = "Angie",
                            SongUrl = "https://example.com/angie"
                        },
                        new
                        {
                            SongId = 5,
                            AlbumId = 1,
                            Name = "Dead Flowers",
                            SongUrl = "https://example.com/dead-flowers"
                        },
                        new
                        {
                            SongId = 6,
                            AlbumId = 1,
                            Name = "Moonlight Mile",
                            SongUrl = "https://example.com/moonlight-mile"
                        },
                        new
                        {
                            SongId = 7,
                            AlbumId = 1,
                            Name = "Bitch",
                            SongUrl = "https://example.com/bitch"
                        },
                        new
                        {
                            SongId = 8,
                            AlbumId = 1,
                            Name = "Sway",
                            SongUrl = "https://example.com/sway"
                        },
                        new
                        {
                            SongId = 9,
                            AlbumId = 1,
                            Name = "Dead Flowers",
                            SongUrl = "https://example.com/dead-flowers"
                        },
                        new
                        {
                            SongId = 10,
                            AlbumId = 1,
                            Name = "Wild Horses (Acoustic Version)",
                            SongUrl = "https://example.com/wild-horses-acoustic"
                        },
                        new
                        {
                            SongId = 11,
                            AlbumId = 2,
                            Name = "Wanna Be Starting Something",
                            SongUrl = "https://example.com/wanna-be-startin-somethin"
                        },
                        new
                        {
                            SongId = 12,
                            AlbumId = 2,
                            Name = "The Girl Is Mine",
                            SongUrl = "https://example.com/the-girl-is-mine"
                        },
                        new
                        {
                            SongId = 13,
                            AlbumId = 2,
                            Name = "Thriller",
                            SongUrl = "https://example.com/thriller"
                        },
                        new
                        {
                            SongId = 14,
                            AlbumId = 2,
                            Name = "Beat It",
                            SongUrl = "https://example.com/beat-it"
                        },
                        new
                        {
                            SongId = 15,
                            AlbumId = 2,
                            Name = "Billie Jean",
                            SongUrl = "https://example.com/billie-jean"
                        },
                        new
                        {
                            SongId = 16,
                            AlbumId = 2,
                            Name = "Human Nature",
                            SongUrl = "https://example.com/human-nature"
                        },
                        new
                        {
                            SongId = 17,
                            AlbumId = 2,
                            Name = "P.Y.T. (Pretty Young Thing)",
                            SongUrl = "https://example.com/pyt"
                        },
                        new
                        {
                            SongId = 18,
                            AlbumId = 2,
                            Name = "Thriller (Instrumental)",
                            SongUrl = "https://example.com/thriller-instrumental"
                        },
                        new
                        {
                            SongId = 19,
                            AlbumId = 2,
                            Name = "Beat It (Extended Version)",
                            SongUrl = "https://example.com/beat-it-extended"
                        },
                        new
                        {
                            SongId = 20,
                            AlbumId = 2,
                            Name = "Billie Jean (Live)",
                            SongUrl = "https://example.com/billie-jean-live"
                        });
                });

            modelBuilder.Entity("SongPlaylist", b =>
                {
                    b.HasOne("mvc.Models.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("mvc.Models.Song", null)
                        .WithMany()
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("mvc.Models.Album", b =>
                {
                    b.HasOne("mvc.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mvc.Models.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("mvc.Models.Song", b =>
                {
                    b.HasOne("mvc.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("mvc.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("mvc.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("mvc.Models.Genre", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
