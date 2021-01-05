using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Peng
{
   public class CustomerServicer
    {
        public static PageList CustomerAll(int pageindex,int pageSize) {
            StorageEntities entit = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entit.Customer orderby p.CtId select new {
                CtId = p.CtId,
                CtName = p.CtName,
                CtIphone = p.CtIphone,
                CtAddress = p.CtAddress,
                Time = p.Time
            };
            list.DataList = obj.Skip((pageindex - 1) * pageSize).Take(pageSize);
            var rows = entit.Customer.Count();
            list.PageCount = rows;
            return list;
           
        }
        public static int Rows() {
            StorageEntities entit = new StorageEntities();
            return entit.Customer.Count();
        }
    }
}
