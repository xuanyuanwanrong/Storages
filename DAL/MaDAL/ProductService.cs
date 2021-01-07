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
        //货品报表
        public static PageList ProductAll(int PageIndex,int PageSize,string pname)
        {
            PageList list = new PageList();
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Product orderby p.PId
                      where p.PName.Contains(pname) && p.PState==0
                      select new
                      {
                          pid = p.PId,
                          pname = p.PName,
                          pcname = p.ProductCategory.PcName,
                          guige = p.Pspecifications,
                          pcount = p.PCount,
                          ctname = p.Customer.CtName
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();
            return list;
        }

        //excel
        public static List<Product> PrList(string pname) {
            StorageEntities entity = new StorageEntities();
            return entity.Product.Where(p => p.PName.Contains(pname)).ToList();
        }
    }
}
