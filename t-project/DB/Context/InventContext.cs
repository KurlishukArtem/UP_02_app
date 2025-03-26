using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using t_project.Database;
using t_project.Models;

namespace t_project.DB.Context
{
    public class InventContext : DbContext
    {
        public DbSet<Inventory> inventory { get; set; }
        //public DbSet<Users> Users { get; set; }
        public InventContext()
        {
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
