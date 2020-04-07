using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNo1.Models
{
    public interface Ihwelcome
    {
        public IEnumerable<Welcome> getHwelcomes();
    }
}
