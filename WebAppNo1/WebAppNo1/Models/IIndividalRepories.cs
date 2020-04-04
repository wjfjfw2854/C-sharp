using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppNo1.Models;

namespace WebAppNo1.Controllers
{
    public interface IIndividalRepories
    {
        public IEnumerable<Individal> getAllIndividal();
        public Individal getIndividal(int index);
    }
}
