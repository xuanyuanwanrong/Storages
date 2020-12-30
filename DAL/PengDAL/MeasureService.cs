using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Peng
{
    public class MeasureService
    {
        public static IQueryable MeasureAll()
        {
            JooWMSEntities j = new JooWMSEntities();
            var obj = from p in j.Measure
                      select new
                      {
                          bianhao = p.MeasureNum,
                          name = p.MeasureName,
                          id = p.ID
                      };
            return obj;
        }
    }
}
