using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
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
            var obj = from p in test.Warehousing where p.WState != 0 select p;
            return obj.Count();
        }

        public static PageList SelectRuKuAll(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing where p.WState!=0
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
                          stateid=p.WState,
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
        
       

        //查询待审核
        public static PageList SelectRuKuDSH(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState ==1
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
            
            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }
        #endregion

        #region 入库单查询审核成功
       
        //查询审核成功
        public static PageList SelectRuKuSHCG(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 2
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

            //设置总页数
            list.PageCount= obj.Count();
            return list;
        }
        #endregion

        #region 入库单查询审核失败
       

        //查询审核失败
        public static PageList SelectRuKuSHSB(int pageIndex, int PageSize)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 3
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
            
            list.PageCount = obj.Count();
            return list;
        }
        #endregion

        #region  入库单条件查询

        #region 根据入库单号查询
        
        //所有
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
          
            list.PageCount = obj.Count();
            return list;
        }

        //查询待审核
        public static PageList SelectRuKuDSHId(int pageIndex, int PageSize,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 1&&p.Wid==id
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

            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }

        //查询审核成功
        public static PageList SelectRuKuSHCGId(int pageIndex, int PageSize,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 2 && p.Wid==id
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

            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }

        //查询审核失败
        public static PageList SelectRuKuSHSBId(int pageIndex, int PageSize,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 3&&p.Wid==id
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

            list.PageCount = obj.Count();
            return list;
        }
        #endregion

        #region 根据日期查询
        //所有
        public static PageList SelectRuKuTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.time>=timeL && p.time<=timeR
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

            list.PageCount = obj.Count();
            return list;
        }
        //查询待审核
        public static PageList SelectRuKuDSHTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 1 && p.time >= timeL && p.time <= timeR
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

            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }

        //查询审核成功
        public static PageList SelectRuKuSHCGTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 2 && p.time >= timeL && p.time <= timeR
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

            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }

        //查询审核失败
        public static PageList SelectRuKuSHSBTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 3 && p.time >= timeL && p.time <= timeR
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

            list.PageCount = obj.Count();
            return list;
        }
        #endregion
        #region 两者查询
        public static PageList SelectRuKuIDTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.time >= timeL && p.time <= timeR && p.Wid==id
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

            list.PageCount = obj.Count();
            return list;
        }

        //查询待审核
        public static PageList SelectRuKuDSHTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 1 && p.time >= timeL && p.time <= timeR&&p.Wid==id
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

            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }

        //查询审核成功
        public static PageList SelectRuKuSHCGTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 2 && p.time >= timeL && p.time <= timeR&&p.Wid==id
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

            //设置总页数
            list.PageCount = obj.Count();
            return list;
        }

        //查询审核失败
        public static PageList SelectRuKuSHSBTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR,int id)
        {
            StorageEntities test = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in test.Warehousing
                      where p.WState == 3 && p.time >= timeL && p.time <= timeR&&p.Wid==id
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

            list.PageCount = obj.Count();
            return list;
        }
        #endregion
        #endregion


    }
}
