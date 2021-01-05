using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.MaDAL
{
    public class WarehousingService
    {
        /// <summary>
        /// 库存清单 所有条件
        /// </summary>
        /// <returns></returns>
        public static PageList WhAll(int PageIndex,int PageSize,int typeid,string name)
        {
            PageList list = new PageList();
            StorageEntities entity = new StorageEntities();
            var obj =from p in entity.Warehousing  where p.WState==2 && p.WareStateType.Tid==typeid && p.Product.PName.Contains(name) orderby p.Wid
                      select new
                      {
                          wid = p.Wid,
                          username = p.User.UserName,
                          time = p.time,
                          tname = p.WareStateType.TName,
                          gname=p.Supplier.SlrName,
                          kleix=p.WareStateType.TName,
                          chanping=p.Product.PName,
                          dizhi=  p.Supplier.SlAddress,
                         pname= p.Product.PName
                          
                      };
            
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();
            return list;
        }
        /// <summary>
        /// 库存清单 不使用入库类型
        /// </summary>
        /// <returns></returns>
        public static PageList WhAll2(int PageIndex, int PageSize, string name)
        {
            PageList list = new PageList();
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Warehousing
                      where p.WState == 2  && p.Product.PName.Contains(name)
                      orderby p.Wid
                      select new
                      {
                          wid = p.Wid,
                          username = p.User.UserName,
                          time = p.time,
                          tname = p.WareStateType.TName,
                          gname = p.Supplier.SlrName,
                          kleix = p.WareStateType.TName,
                          chanping = p.Product.PName,
                          dizhi = p.Supplier.SlAddress,
                          pname = p.Product.PName

                      };

            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();
            return list;
        }
    }

    

}
