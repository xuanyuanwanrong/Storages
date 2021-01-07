using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Peng
{
    //分页查询
    public class CustomerServicer
    {

        public static PageList CustomerAll(int pageindex, int pageSize)
        {
            StorageEntities entit = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entit.Customer
                      orderby p.CtId
                      select new
                      {
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
       
        public static int Rows()
        {
            StorageEntities entit = new StorageEntities();
            return entit.Customer.Count();
        }
        public static int CustomerAdd(Customer C)
        {
            StorageEntities entit = new StorageEntities();
            entit.Customer.Add(C);
            return entit.SaveChanges();
        }
        /// <summary>
        /// 查询客户或者客户编号
        /// </summary>

        public static IQueryable CustomerCxx(string CtName)
        {
            StorageEntities entit = new StorageEntities();
            var obj = from p in entit.Customer
                      where p.CtName.Contains(CtName)
                      select new
                      {
                          CtId = p.CtId,
                          CtName = p.CtName,
                          CtIphone = p.CtIphone,
                          CtAddress = p.CtAddress,
                          Time = p.Time
                      };

            return obj;
        }
        ///删除客户
        //public static int Del(int id)
        //{
        //    StorageEntities entit = new StorageEntities();
        //    var obj = (from p in entit.Customer where p.CtId == id select p).First();
        //    obj.PState = 1;
        //    return entit.SaveChanges();
        //}
    }
}
