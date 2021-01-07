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

        public static PageList SelectRuKuAll(int pageIndex, int PageSize)
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
                          stateid=p.Slid,
                          user = p.User.UserName,
                          time = p.time
                      };
            list.DataList= obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);
            int rows = test.Warehousing.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        #endregion

        #region 入库单查询待审核
        //获取入库单总条数
        public static int RuKuDSHRows()
        {
            StorageEntities test = new StorageEntities();
            var obj = from p in test.Warehousing where p.Slid ==1 select p;
            return obj.Count();
        }

        //查询待审核
        public static PageList SelectRuKuDSH(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.Slid ==1
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
            list.DataList = obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);
            int rows = test.Warehousing.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        #endregion

        #region 入库单查询审核成功
        //获取入库单总条数
        public static int RuKuSHCGRows()
        {
            StorageEntities test = new StorageEntities();
            var obj = from p in test.Warehousing where p.Slid == 2 select p;
            return obj.Count();
        }

        //查询待审核
        public static PageList SelectRuKuSHCG(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.Slid == 2
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
            list.DataList = obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);
            int rows = test.Warehousing.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        #endregion

        #region 入库单查询审核成功
        //获取入库单总条数
        public static int RuKuSHSBRows()
        {
            StorageEntities test = new StorageEntities();
            var obj = from p in test.Warehousing where p.Slid == 3 select p;
            return obj.Count();
        }

        //查询待审核
        public static PageList SelectRuKuSHSB(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.Slid == 3
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
            list.DataList = obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);
            int rows = test.Warehousing.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        #endregion

        #region  入库单条件查询

        #region 根据入库单号查询
        
        public static PageList SelectRuKuID(int pageIndex, int PageSize,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing where p.Wid==id
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
                          stateid = p.Slid,
                          user = p.User.UserName,
                          time = p.time
                      };
            list.DataList = obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);
            int rows = test.Warehousing.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        #endregion
        #endregion
    }
}
