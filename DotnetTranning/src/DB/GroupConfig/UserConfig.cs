using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetTranning.src.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotnetTranning.src.DB.GroupConfig
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            
        }
    }
}