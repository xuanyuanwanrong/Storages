using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.LiuYingXuan;

namespace BLL.LiuYingXuan
{
   public  class WareHouseManager
    {
        public static IQueryable GetWareHouse()
        {
            return WareHouseService.GetWareHouse();
        }
    }
}
