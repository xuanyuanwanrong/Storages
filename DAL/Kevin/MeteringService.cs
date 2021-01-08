using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Kevin
{
    public  class MeteringService
    {
        public static IQueryable GetMetering()
        {
            StorageEntities entities = new StorageEntities();
            var obj = from p in entities.Metering 
                      select new 
                      {
                          Mid = p.Mid,
                          Mname = p.Mname
                      };
            return obj;
        }
    }
}
