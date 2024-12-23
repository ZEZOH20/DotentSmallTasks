using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetTranning.src.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DotnetTranning.src.DB
{
    public class ApplicationDbContext : DbContext
    {
        //DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-QUDQJGK\\SQLEXPRESS;Database=DotnetTranning;Encrypt=false;Integrated Security=True");
        }

    }
}
