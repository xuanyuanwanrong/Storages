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
        /// <summary>
        /// 查询产品类别分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns>PageList</returns>
        public static PageList ProductCategoryList(int PageIndex,int PageSize)
        {
            StorageEntities entities = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entities.ProductCategory
                      orderby p.Pcid
                      where p.PcState == 0
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

        /// <summary>
        /// 新增产品类别
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public static int ProductCategoryAdd(ProductCategory pro)
        {
            StorageEntities entities = new StorageEntities();
            entities.ProductCategory.Add(pro);
            return entities.SaveChanges();
        }
    }
}
