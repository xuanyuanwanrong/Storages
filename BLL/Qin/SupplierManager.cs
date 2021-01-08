using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Qin;
namespace BLL.Qin
{
    public class SupplierManager
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Add(Supplier s)
        {
            return SupplierService.Add(s);
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="SlId"></param>
        /// <returns></returns>
        public static int Del(int SlId)
        {
            return SupplierService.Del(SlId);
        }

        /// <summary>
        /// 根据ID或者姓名查询
        /// </summary>
        /// <param name="SlId"></param>
        /// <param name="SlrName"></param>
        /// <returns></returns>
        public static IQueryable GetByName(int SlId, string SlrName)
        {
            return SupplierService.GetByName(SlId, SlrName);
        }

        /// <summary>
        /// 获取数据表的总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows()
        {
            return SupplierService.GetRows();
        }

        /// <summary>
        /// 供应商管理分页类查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList PageListDemo(int pageIndex, int PageSize, string SlrName)
        {
            return SupplierService.PageListDemo(pageIndex, PageSize, SlrName);
        }
    }
}
