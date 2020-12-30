using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

using DAL.Peng;
namespace BLL.Peng
{
   public  class MeasureManager
    {
        public static IQueryable MeasureAll() {
            return MeasureService.MeasureAll();
        }
    }
}
