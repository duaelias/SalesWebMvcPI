using SalesWebMvcPI.Data;
using SalesWebMvcPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcPI.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcPIContext _context;
        public DepartmentService(SalesWebMvcPIContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
