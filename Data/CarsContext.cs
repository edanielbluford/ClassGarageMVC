using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CGarage.Models;

using Microsoft.EntityFrameworkCore;


namespace CGarage.Data
{
    public class CarsContext : DbContext
    {

        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
        }

        public DbSet<Make> Make { get; set; }
        public DbSet<Model> Enrollments { get; set; }
        public DbSet<VIN> Students { get; set; }
    }
}



