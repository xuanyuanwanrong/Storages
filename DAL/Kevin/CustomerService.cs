using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Kevin
{
    public class CustomerService
    {
        public static IQueryable GetCustomer()
        {
            StorageEntities entities = new StorageEntities();
            var obj = from p in entities.Customer
                      select new
                      {
                          CtId = p.CtId,
                          CtName = p.CtName
                      };
            return obj;
        }
    }
}
