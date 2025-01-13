using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.src.Models;
using Microsoft.EntityFrameworkCore;

namespace back.src.Db
{
    public class ApplicationDbContext(IConfiguration configuration) : DbContext
    {
        private readonly IConfiguration _configuration = configuration;
        DbSet<User> user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));
        }
    }
}