using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieReview.Models;

namespace MovieReview
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Genres> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }
    }
}