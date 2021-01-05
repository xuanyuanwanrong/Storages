                                                                                                                           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Kevin
{
    public class ProductCategoryService
    {
        public static PageList ProductCategoryList(int PageIndex,int PageSize)
        {
            StorageEntities entities = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entities.ProductCategory
                      orderby p.Pcid
                      select new
                      {
                          Pcid = p.Pcid,
                          PcName = p.PcName,
                          PcRemarks = p.PcRemarks,
                          time = p.time,
                          PcState=p.PcState
                      };
            //设置分页数据
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            
            int rows = entities.ProductCategory.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
    }
}
