using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mvc.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataWithNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                columns: new[] { "Price", "Title" },
                values: new object[] { 19.989999999999998, "Sticky Fingers" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                columns: new[] { "Price", "Title" },
                values: new object[] { 24.989999999999998, "Thriller" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "Name",
                value: "The Rolling Stones");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "Name",
                value: "Michael Jackson");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 3, "Eminem" },
                    { 4, "Miles Davis" },
                    { 5, "Daft Punk" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "Hip-Hop music genre", "Hip-Hop" },
                    { 4, "Jazz music genre", "Jazz" },
                    { 5, "Electronic music genre", "Electronic" }
                });

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Name",
                value: "Top Hits");

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "PlaylistId", "Name" },
                values: new object[,]
                {
                    { 2, "Chill Vibes" },
                    { 3, "Throwback Classics" },
                    { 4, "Jazz Essentials" },
                    { 5, "Electronic Beats" }
                });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                columns: new[] { "Name", "SongUrl" },
                values: new object[] { "Brown Sugar", "https://example.com/brown-sugar" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2,
                columns: new[] { "AlbumId", "Name", "SongUrl" },
                values: new object[] { 1, "Wild Horses", "https://example.com/wild-horses" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "Name", "SongUrl" },
                values: new object[,]
                {
                    { 3, 1, "Can't You Hear Me Knocking", "https://example.com/cant-you-hear-me-knocking" },
                    { 4, 1, "Angie", "https://example.com/angie" },
                    { 5, 1, "Dead Flowers", "https://example.com/dead-flowers" },
                    { 6, 1, "Moonlight Mile", "https://example.com/moonlight-mile" },
                    { 7, 1, "Bitch", "https://example.com/bitch" },
                    { 8, 1, "Sway", "https://example.com/sway" },
                    { 9, 1, "Dead Flowers", "https://example.com/dead-flowers" },
                    { 10, 1, "Wild Horses (Acoustic Version)", "https://example.com/wild-horses-acoustic" },
                    { 11, 2, "Wanna Be Starting Something", "https://example.com/wanna-be-startin-somethin" },
                    { 12, 2, "The Girl Is Mine", "https://example.com/the-girl-is-mine" },
                    { 13, 2, "Thriller", "https://example.com/thriller" },
                    { 14, 2, "Beat It", "https://example.com/beat-it" },
                    { 15, 2, "Billie Jean", "https://example.com/billie-jean" },
                    { 16, 2, "Human Nature", "https://example.com/human-nature" },
                    { 17, 2, "P.Y.T. (Pretty Young Thing)", "https://example.com/pyt" },
                    { 18, 2, "Thriller (Instrumental)", "https://example.com/thriller-instrumental" },
                    { 19, 2, "Beat It (Extended Version)", "https://example.com/beat-it-extended" },
                    { 20, 2, "Billie Jean (Live)", "https://example.com/billie-jean-live" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 3, null, 3, 3, 15.99, "The Marshall Mathers LP" },
                    { 4, null, 4, 4, 29.989999999999998, "Kind of Blue" },
                    { 5, null, 5, 5, 22.989999999999998, "Random Access Memories" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                columns: new[] { "Price", "Title" },
                values: new object[] { 10.99, "Album1" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                columns: new[] { "Price", "Title" },
                values: new object[] { 12.99, "Album2" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "Name",
                value: "Artist1");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "Name",
                value: "Artist2");

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Name",
                value: "Playlist1");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                columns: new[] { "Name", "SongUrl" },
                values: new object[] { "Song1", "https://example.com/song1" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2,
                columns: new[] { "AlbumId", "Name", "SongUrl" },
                values: new object[] { 2, "Song2", "https://example.com/song2" });
        }
    }
}
