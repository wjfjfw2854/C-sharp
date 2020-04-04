using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNo1.Models
{
    public class IConptionMockRepories : IConptionRepories
    {
        private List<Conption> _list;
        public IEnumerable<Conption> getAllAddress()
        {
            createConption();
            return _list;
        }

        private IList<Conption> createConption()
        {
            if(_list == null)
            {
                var list = new List<Conption>();
                for(var i = 0;i < 6;i++)
                {
                    Conption conption = new Conption();
                    conption.address = "吴中路800弄30号40" + i;
                    list.Add(conption);
                }
                _list = list;
            }
            return _list;
        }
    }
}
