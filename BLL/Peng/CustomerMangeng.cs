using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Peng;
namespace BLL.Peng
{
    public class CustomerMangeng
    {
        public static PageList CustomerAll(int pageindex, int pageSize)
        {
            return CustomerServicer.CustomerAll(pageindex, pageSize);
        }
        public static int Rows()
        {
            return CustomerServicer.Rows();
        }
        public static int CustomerAdd(Customer C)
        {
            return CustomerServicer.CustomerAdd(C);
        }
        public static IQueryable CustomerCxx(string CtName)
        {

            return CustomerServicer.CustomerCxx(CtName);

        }
       

        //public static int Del(int id)
        //{
        //    return CustomerServicer.Del(id);
        //}
    }
}
