using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppNo1.Controllers;

namespace WebAppNo1.Models
{
    public class IndividalRepository : IIndividalRepories
    {
        private readonly AppDbContext _context;
        public IndividalRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IEnumerable<Individal> getAllIndividal()
        {
            return _context.Individals;
        }

        public Individal getIndividal(int index)
        {
            return _context.Individals.FirstOrDefault(n => n.id == index);
        }
    }
}
