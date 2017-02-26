using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    class AnimalContext : DbContext
    {
        // Setting up to use Animal table in db.
        public DbSet<Animal> animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Referencing the databasefile that we will work with.
            // string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            optionsBuilder.UseSqlite("Filename=AnimalFarm.db");
        }
    }
}
