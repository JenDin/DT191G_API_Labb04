using System;
using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    // Song class
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string? Artist { get; set; }

        [Required]
        public string? SongTitle { get; set; }

        [Required]
        public int SongLength { get; set; }

        [Required]
        public string? Category { get; set; }

        // Foreign key to the album table
        public int AlbumId { get; set; }

        public Album? Album { get; set; }
    }

    // Album class
    public class Album
    {
        public int Id { get; set; }

        [Required]
        public string? AlbumTitle { get; set; }
    }
}