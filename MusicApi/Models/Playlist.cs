using System;
namespace MusicApi.Models
{
	public class Song
	{
		public int Id { get; set; }

		public string? Artist { get; set; }

		public string? SongTitle { get; set; }

		public string? Category { get; set; }
	}
}

