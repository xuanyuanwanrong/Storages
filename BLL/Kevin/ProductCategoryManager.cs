using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Kevin;

namespace BLL.Kevin
{
    public class ProductCategoryManager
    {
        public static PageList ProductCategoryList(int PageIndex, int PageSize)
        {
            return ProductCategoryService.ProductCategoryList(PageIndex, PageSize);
        }
        public static int ProductCategoryAdd(ProductCategory pro)
        {
            return ProductCategoryService.ProductCategoryAdd(pro);
        }
        /// <summary>
        /// 删除产品类别（改状态）
        /// </summary>
        /// <param name="PcId"></param>
        /// <returns></returns>
        public static int ProductCategoryDel(int PcId)
        {
            return ProductCategoryService.ProductCategoryDel(PcId);
        }
        public static IQueryable ProductCategoryByPcid(int Pcid)
        {
            return ProductCategoryService.ProductCategoryByPcid(Pcid);
        }
        public static int ProductCategoryUpd(ProductCategory pro)
        {
            return ProductCategoryService.ProductCategoryUpd(pro);
        }
    }
}
