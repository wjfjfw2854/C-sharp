using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppNo1.Models
{
    public class ConptionReposity : IConptionRepories
    {
        private readonly AppDbContext _context;
        public ConptionReposity(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IEnumerable<Conption> getAllAddress()
        {
            return _context.Conptions;
        }
    }
}
