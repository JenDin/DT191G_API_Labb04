using System;
namespace MusicApi.Models
{
    // Song class
    public class Song
    {
        public int Id { get; set; }

        public string? Artist { get; set; }

        public string? SongTitle { get; set; }

        public string? Category { get; set; }

        // Foreign key to the album table
        public int AlbumId { get; set; }

        public Album? Album { get; set; }
    }

    // Album class
    public class Album
    {
        public int Id { get; set; }

        public string? AlbumTitle { get; set; }

        public List<Song>? Songs { get; set; }
    }
}