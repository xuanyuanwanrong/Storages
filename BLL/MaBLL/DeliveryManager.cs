using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.MaDAL;
namespace BLL.MaBLL
{
  public  class DeliveryManager
    {
        //查询出库表
        public static PageList DeliveryAll(int PageIndex, int PageSize,int Day) {
            DateTime MaxTime;
            DateTime MinTime;
            if (Day != 0)
            {
                MaxTime = DateTime.Now;
                 MinTime = DateTime.Now;
                MinTime.AddDays(-Day);
            }
            else {
                MaxTime = DateTime.MaxValue;
                MinTime = DateTime.MinValue;
            }
            
            return DeliveryService.DeliveryAll(PageIndex,PageSize, MaxTime, MinTime);
        }

        public static PageList PaiHang(int Day) {
            DateTime MaxTime= DateTime.Now;
            DateTime MinTime= DateTime.Now;
            if (Day != 0)
            {
                MinTime.AddDays(-Day);
            }
            else {
                MaxTime = DateTime.MaxValue;
                MinTime = DateTime.MinValue;
            }
            return DeliveryService.PaiHang(MaxTime,MinTime);
        }
    }
}
