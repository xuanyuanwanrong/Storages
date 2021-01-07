using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Kevin;

namespace BLL.Kevin
{
    public class ProductManager
    {
        public static PageList ProductList(int PageIndex, int PageSize, string PName)
        {
            return ProductService.ProductList(PageIndex, PageSize, PName);
        }
        public static int ProductAdd(Product pro)
        {
            return ProductService.ProductAdd(pro);
        }
    }
}
