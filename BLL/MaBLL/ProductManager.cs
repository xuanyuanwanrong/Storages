using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MaDAL;
using Models;
namespace BLL.MaBLL
{
   public class ProductManager
    {
        //货品报表
        public static PageList ProductAll(int PageIndex, int PageSize, string pname) {
            return ProductService.ProductAll(PageIndex,PageSize,pname);
        }
        //excel
        public static List<Product> PrList(string pname) {
            return ProductService.PrList(pname);
        }
    }
}
