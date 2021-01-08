using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Qin
{
    public class SupplierTypeService
    {
        /// <summary>
        /// 下拉列表框
        /// </summary>
        /// <returns></returns>
        public static IQueryable GetSupplierType()
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.SupplierType
                      select new
                      {
                          SupplierTypeId = p.SupplierTypeId,
                          SupplierTypeName = p.SupplierTypeName

                      };
            return obj;

        }
    }
}
