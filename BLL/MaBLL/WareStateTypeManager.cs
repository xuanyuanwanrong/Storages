using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MaDAL;
namespace BLL.MaBLL
{
   public class WareStateTypeManager
    {
        /// <summary>
        /// 查询所有入库类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable WsTypeAll()
        {
            return WareStateTypeService.WsTypeAll();
        }
        }
}
