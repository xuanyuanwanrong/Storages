using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.MaDAL
{
    public class ProductService
    {
        public static IQueryable ProductAll(int PageIndex,int PageSize)
        {
            PageList list = new PageList();
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Product
                      select new
                      {
                          pid = p.PId,
                          pname = p.PName,
                          pcname = p.ProductCategory.PcName,
                          guige = p.Pspecifications,
                          pcount = p.PCount,
                          ctname = p.Customer.CtName
                      };
            return obj;
        }
    }
}
