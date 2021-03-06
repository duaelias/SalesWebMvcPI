﻿using System;
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

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> salesRecords { get; set; }
        public object SalesRecord { get; internal set; }
    }
}
