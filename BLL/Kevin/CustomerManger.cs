using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Kevin;

namespace BLL.Kevin
{
    public class CustomerManger
    {
        public static IQueryable GetCustomer()
        {
            return CustomerService.GetCustomer();
        }
    }
}
