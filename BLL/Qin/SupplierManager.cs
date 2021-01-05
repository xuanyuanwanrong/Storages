using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Qin;
namespace BLL
{
    public class SupplierManager
    {

        public static IQueryable GetByName(string SlrName)
        {
            return SupplierService.GetByName(SlrName);
        }
            public static IQueryable GetAll()
        {
            return SupplierService.GetAll();
        }
    }
}
