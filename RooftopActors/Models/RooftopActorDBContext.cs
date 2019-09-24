using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RooftopActors.Models
{
    public class RooftopActorDBContext: DbContext
    {
        public DbSet<Project> Project { get; set; }
        public DbSet<Actors> Actors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }

    }
}