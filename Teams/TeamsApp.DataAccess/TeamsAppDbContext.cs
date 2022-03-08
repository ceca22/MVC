using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeamsApp.Domain.Models;

namespace TeamsApp.DataAccess
{
    public class TeamsAppDbContext:DbContext
    {
        public TeamsAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding
            //modelBuilder.Entity<Player>()
            //    .HasData(
            //    new Player()
            //    {

            //    },
            //    new Player()
            //    {

            //    });

            //modelBuilder.Entity<Team>()
            //    .HasData(
            //    new Team()
            //    {
            //    }
            //    );
        
        }
    }
}
