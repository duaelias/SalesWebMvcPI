using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcPI.Models;

namespace SalesWebMvcPI.Data
{
    public class SalesWebMvcPIContext : DbContext
    {
        public SalesWebMvcPIContext (DbContextOptions<SalesWebMvcPIContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcPI.Models.Department> Department { get; set; }
    }
}
