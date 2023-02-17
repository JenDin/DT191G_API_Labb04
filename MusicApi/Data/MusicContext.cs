using System;
using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Data
{
	public class MusicContext : DbContext
	{
		public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
		}

		public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }
    }
}