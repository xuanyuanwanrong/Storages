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
        /// 库存清单
        /// </summary>
        /// <returns></returns>
        public static PageList WhAll(int PageIndex,int PageSize)
        {
            PageList list = new PageList();
            StorageEntities entity = new StorageEntities();
            var obj =from p in entity.Warehousing orderby p.Wid
                      select new
                      {
                          wid = p.Wid,
                          username = p.User.UserName,
                          time = p.time,
                          tname = p.WareStateType.TName
                      };
            
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();
            return list;
        }
    }
}
