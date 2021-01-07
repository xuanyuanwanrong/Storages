using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.MaDAL
{
    public class DeliveryService
    {
        //查询出库表
        public static PageList DeliveryAll(int PageIndex, int PageSize,DateTime MaxTime,DateTime MinTime)
        {
            StorageEntities entity = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entity.Delivery
                      where p.Dtid == 2 && p.time<=MaxTime &&p.time>=MinTime orderby p.DeId
                      select new
                      {
                          deid = p.DeId,
                          ctname = p.Customer.CtName,
                          wid = p.Warehousing.Wid,
                          time = p.time,
                          ftime = p.Ftime,
                          username = p.User.UserName,
                          decount = p.DeCount
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();
            return list;
        }
        public static PageList PaiHang(DateTime MaxTime,DateTime MinTime) {
            PageList list = new PageList();
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Delivery where MinTime<=p.time && p.time<=MaxTime orderby p.DeCount descending
                      select new
                      {
                        deid=  p.DeId,
                        deount=  p.DeCount,
                        time=  p.time
                      };
            list.DataList = obj.Skip(0).Take(5);
            return list;
        }
    }
}
