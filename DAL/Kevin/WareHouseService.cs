using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Kevin
{
    public class WareHouseService
    {
        public static IQueryable GetWareHouse()
        {
            StorageEntities entities = new StorageEntities();
            var obj = from p in entities.WareHouse
                      where p.WhStateId==2
                      select new
                      {
                          WhId = p.WhId,
                          WhName = p.WhName
                      };
            return obj;
        }
    }
}
