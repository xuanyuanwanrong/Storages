using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Kevin
{
    public  class ProductService
    {
        public static PageList ProductList(int PageIndex, int PageSize, string PName)
        {
            StorageEntities entities = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entities.Product
                      orderby p.PId
                      where p.PState == 0 && p.PName.Contains(PName)
                      select new
                      {
                          PId = p.PId,
                          PName = p.PName,
                          PRemarks = p.PRemarks,
                          PState = p.PState,
                          PPrice = p.PPrice,
                          Pspecifications = p.Pspecifications,
                          PCount = p.PCount,
                          Mname = p.Metering.Mname,
                          PcName = p.ProductCategory.PcName,
                          WhName = p.WareHouse.WhName,
                          CtName = p.Customer.CtName,
                      };
            //设置分页数据
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);


            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }
        public static int ProductAdd(Product pro)
        {
            StorageEntities entities = new StorageEntities();
            entities.Product.Add(pro);
            return entities.SaveChanges();
        }
    }
}
