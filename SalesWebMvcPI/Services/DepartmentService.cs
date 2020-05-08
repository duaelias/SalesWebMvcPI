using SalesWebMvcPI.Data;
using SalesWebMvcPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcPI.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcPIContext _context;
        public DepartmentService(SalesWebMvcPIContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }


    }
}
