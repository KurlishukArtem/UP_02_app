using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using t_project.Database;
using t_project.Models;

namespace t_project.DB.Context
{
    public class NetSettingsContext : DbContext
    {
        public DbSet<NetSettings> net_settings { get; set; }
        //public DbSet<Users> Users { get; set; }
        public NetSettingsContext()
        {
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
