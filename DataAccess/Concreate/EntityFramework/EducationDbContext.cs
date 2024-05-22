using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EducationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HUF82E8\KUBRASONMEZMSSQL;Database=EducationManagementPlatform;Trusted_Connection = true");
        }
        
        public DbSet<Education> Education { get; set; }
    }
}
