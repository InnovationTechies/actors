using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RooftopActors.Models
{
    /// <summary>
    /// DBContext connects and creates the database
    ///
    /// </summary>
    public class RooftopActorDBContext: DbContext
    {
        public DbSet<Project> Project { get; set; }
        public DbSet<Actors> Actors { get; set; }

        /// <summary>
        /// thsi will tell the the db to use the stored procedures in the Repositor when using this class
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // This line will tell entity framework to use stored procedures
            // when inserting, updating and deleting Employees
            modelBuilder.Entity<Actors>().MapToStoredProcedures()
                .HasMany(t => t.Projects)
                .WithMany(t => t.Actors)
                .Map(m =>
                {
                    m.ToTable("ActorProjects");
                    m.MapLeftKey("ActorID");
                    m.MapRightKey("ProjectID");
                });


            base.OnModelCreating(modelBuilder);

            
        }
    }
}