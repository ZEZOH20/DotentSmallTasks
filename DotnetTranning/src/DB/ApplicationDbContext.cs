using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetTranning.src.DB.GroupConfig;
using DotnetTranning.src.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DotnetTranning.src.DB
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=ABDULRAHMAN\\SQLEXPRESS;Database=DotnetTranning;Encrypt=false;Integrated Security=True");
            ////"server=ABDULRAHMAN\\SQLEXPRESS;database=manhole;Encrypt=False;Integrated Security=True"
             // "Server=DESKTOP-QUDQJGK\\SQLEXPRESS"
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfig).Assembly);
        }

    }
}
