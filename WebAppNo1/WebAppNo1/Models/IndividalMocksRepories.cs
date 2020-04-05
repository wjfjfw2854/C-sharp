using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppNo1.Controllers;

namespace WebAppNo1.Models
{
    public class IndividalMocksRepories : IIndividalRepories
    {
        public List<Individal> _list;
        public IEnumerable<Individal> getAllIndividal()
        {
            createList();
            return _list;
        }

        public Individal getIndividal(int index)
        {
            return _list.FirstOrDefault();
        }

        public IList<Individal> createList()
        {
            if (_list == null)
            {
                var list = new List<Individal>();
                for (int i = 0; i < 5; i++)
                {
                    var individal = new Individal();
                    individal.id = i;
                    individal.age = "2" + i;
                    individal.sex = i / 2 == 0 ? "female" : "male";
                    individal.name = "小一泽wait_" + i;
                    individal.province = "黄寄_of_冥王系_" + i;
                    list.Add(individal);
                }
                _list = list;
            }

            return _list;
        }
    }
}
