using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Lxy
{
   public class RuKu
    {
        #region  入库单查询所有
        ///<summary>
        ///获取入库单总条数
        /// </summary>

        public static int RuKuRows()
        {
            StorageEntities test = new StorageEntities();
            return test.Warehousing.Count();
        }

        public static IQueryable SelectRuKuAll(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      orderby p.Wid
                      select new
                      {
                          wid = p.Wid,
                          tname = p.WareStateType.TName,
                          sname = p.Supplier.SlrName,
                          rid = p.Rid,
                          num = from pp in p.WareProduct where p.Wid == pp.Wid select pp.WPnum,
                          price = from pp in p.WareProduct where p.Wid == pp.Wid select pp.WPprice,
                          state = p.WareState.Sname,
                          user = p.User.UserName,
                          time = p.time
                      };
            return obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);
        }
        #endregion
    }
}
