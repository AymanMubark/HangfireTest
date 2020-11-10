using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HangfireTest.Models;

namespace HangfireTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Auction>().HasData(new Auction() { ID = 1, Name = "First", StartAt = DateTime.Now.AddMinutes(10), });
            modelBuilder.Entity<Auction>().HasData(new Auction() { ID = 2, Name = "Second", StartAt = DateTime.Now.AddMinutes(20), });
        }
        public DbSet<Auction> Auctions { get; set; }
    }
}
