using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using t_project.Database;
using t_project.Models;

namespace t_project.DB.Context
{

    public class EquipContext : DbContext
    {
        public DbSet<Equipment> equipment {  get; set; }
        //public DbSet<Users> Users { get; set; }
        public EquipContext()
        {
            Database.EnsureCreated();
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
