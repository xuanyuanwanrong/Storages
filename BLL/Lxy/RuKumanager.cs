using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Lxy;

namespace BLL.Lxy
{
   public class RuKumanager
    {
        #region  入库单查询所有
        ///<summary>
        ///获取入库单总条数
        /// </summary>

        public static int RuKuRows()
        {
            return RuKu.RuKuRows();
        }

        public static IQueryable SelectRuKuAll(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuAll(pageIndex, PageSize);
        }
        #endregion
    }
}
