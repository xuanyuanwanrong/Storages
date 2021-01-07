using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
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

        public static PageList SelectRuKuAll(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuAll(pageIndex, PageSize);
        }
        #endregion

        #region 入库单查询待审核
        //获取入库单总条数
        public static int RuKuDSHRows()
        {
            return RuKu.RuKuDSHRows();
        }

        //查询待审核
        public static PageList SelectRuKuDSH(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuDSH(pageIndex,PageSize);
        }
        #endregion
        #region 入库单查询审核成功
        //获取入库单总条数
        public static int RuKuSHCGRows()
        {
            return RuKu.RuKuSHCGRows();
        }

        //查询待审核
        public static PageList SelectRuKuSHCG(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuSHCG(pageIndex, PageSize);
        }
        #endregion
        #region 入库单查询审核失败
        //获取入库单总条数
        public static int RuKuSHSBRows()
        {
            return RuKu.RuKuSHSBRows();
        }

        //查询待审核
        public static PageList SelectRuKuSHSB(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuSHSB(pageIndex, PageSize);
        }
        #endregion

        #region  入库单条件查询

        #region 根据入库单号查询
        

        public static PageList SelectRuKuID(int pageIndex, int PageSize, int id)
        {
            return RuKu.SelectRuKuID(pageIndex,PageSize,id);
        }
        #endregion
        #endregion
    }

}
