using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicRater.Models
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Rating { get; set; }
        public string Notes { get; set; }
    }

    public class MusicDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
    }
}