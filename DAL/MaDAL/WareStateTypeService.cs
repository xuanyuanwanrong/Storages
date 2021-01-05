using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.MaDAL
{
   public class WareStateTypeService
    {
        /// <summary>
        /// 查询所有入库类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable WsTypeAll() {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.WareStateType
                      select new
                      {
                        tid=  p.Tid,
                        tname=  p.TName
                      };
            return obj;
        }
    }
}
