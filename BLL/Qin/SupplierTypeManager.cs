using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Qin;
namespace BLL.Qin
{
    public class SupplierTypeManager
    {
        /// <summary>
        /// 下拉列表框
        /// </summary>
        /// <returns></returns>
        public static IQueryable GetSupplierType()
        {
            return SupplierTypeService.GetSupplierType();
        }
    }
}
