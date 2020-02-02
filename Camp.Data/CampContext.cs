using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Camp.Data
{

    public class CampContext : DbContext
    {
        private string _connectionString;
        public CampContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Camper> Campers { get; set; }
        public DbSet<Bunk> Bunk { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }


    }
}
