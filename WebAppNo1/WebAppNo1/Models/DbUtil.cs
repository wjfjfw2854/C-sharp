using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNo1.Models
{
    public static class DbUtil
    {
        public static void LoadTableConption(AppDbContext appDbContext)
        {
            if (appDbContext.Conptions.Any())
            {
                return;
            }
            appDbContext.AddRange(
             new Conption { /*id=0,*/address = "烈中路800弄30号400", direct = "杨城太守0", primilry = "40" + "部门", forien = true},
             new Conption { /*id=1,*/address = "烈中路800弄30号401", direct = "杨城太守1", primilry = "41" + "部门", forien = false },
             new Conption { /*id=2,*/address = "烈中路800弄30号402", direct = "杨城太守2", primilry = "42" + "部门", forien = true },
             new Conption { /*id=3,*/address = "烈中路800弄30号403", direct = "杨城太守3", primilry = "43" + "部门", forien = false },
             new Conption { /*id=4,*/address = "烈中路800弄30号404", direct = "杨城太守4", primilry = "44" + "部门", forien = true },
             new Conption { /*id=5,*/address = "烈中路800弄30号405", direct = "杨城太守5", primilry = "45" + "部门", forien = false },
             new Conption { /*id=6,*/address = "烈中路800弄30号406", direct = "杨城太守6", primilry = "46" + "部门", forien = true },
             new Conption { /*id=7,*/address = "烈中路800弄30号407", direct = "杨城太守7", primilry = "47" + "部门", forien = false },
             new Conption { /*id=8,*/address = "烈中路800弄30号408", direct = "杨城太守8", primilry = "48" + "部门", forien = true },
             new Conption { /*id=9,*/address = "烈中路800弄30号409", direct = "杨城太守9", primilry = "49" + "部门", forien = false },
             new Conption { /*id=9,*/address = "烈中路800弄30号410", direct = "杨城太守10", primilry = "50" + "部门",forien = true }
            );
            appDbContext.SaveChanges();
        }
        public static void LoadTableIndivial(AppDbContext appDbContext)
        {
            if (appDbContext.Individals.Any())
            {
                return;
            }
            appDbContext.AddRange(
                new Individal { /*id =0, */age = "20", sex = "female", name = "小一泽wait_0", province = "黄寄_of_冥王系_0", macle = true },
                new Individal { /*id =1,*/ age = "21", sex = "female", name = "小一泽wait_1", province = "黄寄_of_冥王系_1", macle = false },
                new Individal { /*id =2,*/ age = "22", sex = "female", name = "小一泽wait_2", province = "黄寄_of_冥王系_2", macle = true },
                new Individal { /*id =3,*/ age = "23", sex = "female", name = "小一泽wait_3", province = "黄寄_of_冥王系_3", macle = false },
                new Individal { /*id =4,*/ age = "24", sex = "female", name = "小一泽wait_4", province = "黄寄_of_冥王系_4", macle = true },
                new Individal { /*id =5,*/ age = "25", sex = "female", name = "小一泽wait_5", province = "黄寄_of_冥王系_5", macle = false },
                new Individal { /*id =6,*/ age = "26", sex = "female", name = "小一泽wait_6", province = "黄寄_of_冥王系_6", macle = true },
                new Individal { /*id =6,*/ age = "27", sex = "female", name = "小一泽wait_7", province = "黄寄_of_冥王系_7", macle = false },
                new Individal { /*id =6,*/ age = "28", sex = "female", name = "小一泽wait_8", province = "黄寄_of_冥王系_8", macle = true }
            );
            appDbContext.SaveChanges();
        }
    }
}
