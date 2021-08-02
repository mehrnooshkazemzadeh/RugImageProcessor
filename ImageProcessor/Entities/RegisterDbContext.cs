using ImageProcessor.Models;
using ImageProcessor.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessor.Entities
{
    public class RegisterDbContext : DbContext
    {
        public DbSet<RegisterKey> RegisterKeys { get; set; }
        public DbSet<RegisterKeyMac> RegisterKeyMacs { get; set; }
        public DbSet<BlackList> BlackLists { get; set; }
        public RegisterDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.ConnectionString);
        }
    }
}
