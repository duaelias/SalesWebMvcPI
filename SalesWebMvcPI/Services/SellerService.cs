using SalesWebMvcPI.Data;
using SalesWebMvcPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcPI.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcPIContext _context;
        public SellerService(SalesWebMvcPIContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {

            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
