using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ConsoleApp1.Infrastructure
{
    class WorkContext:DbContext
    {
        private readonly string _connString;
        public WorkContext(string connString) : base()
        {
            _connString = connString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Cook>().ToTable("Cooks");
        //    modelBuilder.Entity<Driver>().ToTable("Drivers");
        //}
        //for Tpt
        public Microsoft.EntityFrameworkCore.DbSet<Worker> Workers { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cook> Cooks { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Driver> Drivers { get; set; }
        
    }
}
