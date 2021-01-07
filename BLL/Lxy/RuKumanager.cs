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
       

        //查询待审核
        public static PageList SelectRuKuDSH(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuDSH(pageIndex,PageSize);
        }
        #endregion
        #region 入库单查询审核成功
       
        //查询待审核
        public static PageList SelectRuKuSHCG(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuSHCG(pageIndex, PageSize);
        }
        #endregion
        #region 入库单查询审核失败
       
        //查询待审核
        public static PageList SelectRuKuSHSB(int pageIndex, int PageSize)
        {
            return RuKu.SelectRuKuSHSB(pageIndex, PageSize);
        }
        #endregion

        #region  入库单条件查询

        #region 根据入库单号查询
        
        //所有
        public static PageList SelectRuKuID(int pageIndex, int PageSize, int id)
        {
            return RuKu.SelectRuKuID(pageIndex,PageSize,id);
        }

        //查询待审核
        public static PageList SelectRuKuDSHId(int pageIndex, int PageSize, int id)
        {
            return RuKu.SelectRuKuDSHId(pageIndex, PageSize, id);
        }

        //查询审核成功
        public static PageList SelectRuKuSHCGId(int pageIndex, int PageSize, int id)
        {
            return RuKu.SelectRuKuSHCGId(pageIndex, PageSize, id);
        }

        //查询审核失败
        public static PageList SelectRuKuSHSBId(int pageIndex, int PageSize, int id)
        {
            return RuKu.SelectRuKuSHSBId(pageIndex, PageSize, id);
        }
        #endregion

        #region 根据入库时间查询
        //所有
        public static PageList SelectRuKuTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return RuKu.SelectRuKuTime(pageIndex, PageSize, timeL,timeR);
        }

        //查询待审核
        public static PageList SelectRuKuDSHTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return RuKu.SelectRuKuDSHTime(pageIndex, PageSize, timeL,timeR);
        }

        //查询审核成功
        public static PageList SelectRuKuSHCGTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return RuKu.SelectRuKuSHCGTime(pageIndex, PageSize, timeL,timeR);
        }

        //查询审核失败
        public static PageList SelectRuKuSHSBTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return RuKu.SelectRuKuSHSBTime(pageIndex, PageSize,timeL,timeR );
        }
        #endregion

        #region 两者查询
        public static PageList SelectRuKuIDTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return RuKu.SelectRuKuIDTime(pageIndex,PageSize,timeL,timeR,id);
        }

        //查询待审核
        public static PageList SelectRuKuDSHTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return RuKu.SelectRuKuDSHTimeId(pageIndex, PageSize, timeL, timeR,id);
        }

        //查询审核成功
        public static PageList SelectRuKuSHCGTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return RuKu.SelectRuKuSHCGTimeId(pageIndex, PageSize, timeL, timeR,id);
        }

        //查询审核失败
        public static PageList SelectRuKuSHSBTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return RuKu.SelectRuKuSHSBTimeId(pageIndex, PageSize, timeL, timeR,id);
        }
        #endregion
        #endregion
    }

}
