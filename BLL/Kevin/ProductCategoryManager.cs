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
    }
}
