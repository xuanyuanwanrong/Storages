using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Peng;
namespace BLL.Peng
{
    public class MeteringMangeng
    {
        public static PageList MeteringAll(int pageindex, int pageSize)
        {

            return MeteringSerivcer.MeteringAll(pageindex, pageSize);
        }
        public static int Rowss()
        {
            return MeteringSerivcer.Rowss();
        }
    }
}
