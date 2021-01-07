using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Peng
{
    public class MeteringSerivcer
    {
        public static PageList MeteringAll(int pageindex, int pageSize)
        {
            StorageEntities entit = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entit.Product
                      orderby p.MId
                      select new
                      {
                          Mid = p.Metering.Mid,
                          Mname = p.Metering.Mname,
                          MId = p.MId,

                      };
            list.DataList = obj.Skip((pageindex - 1) * pageSize).Take(pageSize);
            var rows = entit.Customer.Count();
            list.PageCount = rows;
            return list;
        }
        public static int Rowss()
        {
            StorageEntities entit = new StorageEntities();
            return entit.Customer.Count();
        }
    }
}
