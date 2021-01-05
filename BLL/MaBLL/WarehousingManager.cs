using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.MaDAL;
namespace BLL.MaBLL
{
   public class WarehousingManager
    {
        /// <summary>
        /// 库存清单
        /// </summary>
        /// <returns></returns>
        public static PageList WhAll(int PageIndex,int PageSize,int typeid,string name) {
            if (typeid==0) {
                return WarehousingService.WhAll2(PageIndex,PageSize,name);
            }
            return WarehousingService.WhAll(PageIndex,PageSize,typeid,name);
        }
    }
}
