using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.MaDAL;
namespace BLL.MaBLL
{
   public class UserManager
    {
        //登录
        public static User Login(string name, string pwd) {
            return UserService.Login(name,pwd);
        }
    }
}
