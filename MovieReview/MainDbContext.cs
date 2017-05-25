using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieReview.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;

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

        public DbSet<Movies> Movies { get; set; }


        public virtual ObjectResult<GetUserRole_Result> GetUserRole(string userEmail)
        {
            var userEmailParameter = userEmail != null ?
                new SqlParameter("userEmail", userEmail) :
                new SqlParameter("userEmail", typeof(string));

            //return ((IObjectContextAdapter)this).ObjectContext.Database.SqlQuery<GetUserRole_Result>("GetUserRole @userEmail", userEmailParameter).SingleOrDefault();
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<GetUserRole_Result>("UserRoleProcedure @userEmail", userEmailParameter);
        }


    }
}