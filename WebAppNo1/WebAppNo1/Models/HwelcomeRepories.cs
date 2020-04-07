using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNo1.Models
{
    public class HwelcomeRepories : Ihwelcome
    {
        private AppDbContext _appDbContext;
        public HwelcomeRepories(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Welcome> getHwelcomes()
        {
            var list = new List<Welcome>();
            for(int i = 0;i < 10;i++)
            {
                var w = new Welcome();
                w.isNew = i % 2 == 0 ? true : false;
                Console.WriteLine("em>>>>i=" + i + "w.isNew=" + w.isNew);
                w.how = "How" + i;
                w.are = "are" + i;
                w.you = "you" + i;
                w.nice = "nice to meet you too!" + i;
                list.Add(w);
            }
            return list;
        }
    }
}
