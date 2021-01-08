using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.MaDAL
{
  public  class UserService
    {
        //登录
        public static User Login(string name,string pwd) {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.User where p.UserName == name && p.PassWord == pwd select p;
            return obj.FirstOrDefault();
        }
    }
}
