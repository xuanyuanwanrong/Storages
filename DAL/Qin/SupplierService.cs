using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Qin
{
    public class SupplierService
    {
        public static IQueryable GetAll()
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Supplier
                      select new
                      {
                          SlId = p.SlId,
                          SupplierTypeName = p.SupplierType.SupplierTypeName,
                          SlrName = p.SlrName,
                          SlDescribe = p.SlDescribe,
                          SlContacts = p.SlContacts,
                          SlIphone = p.SlIphone,
                          SlAddress = p.SlAddress
                      };
            return obj;
        }
    }
}
