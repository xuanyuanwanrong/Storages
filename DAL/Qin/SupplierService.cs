using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Qin
{
    public class SupplierService
    {

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Add(Supplier s)
        {
            StorageEntities entity = new StorageEntities();
            entity.Supplier.Add(s);
            return entity.SaveChanges();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="SlId"></param>
        /// <returns></returns>
        public static int Del(int SlId)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.Supplier where p.SlId == SlId select p).First();
            entity.Supplier.Remove(obj);
            return entity.SaveChanges();
        }

       /// <summary>
       /// 根据ID或者姓名查询
       /// </summary>
       /// <param name="SlId"></param>
       /// <param name="SlrName"></param>
       /// <returns></returns>
        public static IQueryable GetByName(int SlId, string SlrName)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.Supplier
                       where p.SlId == SlId && p.SlrName.Contains(SlrName)
                       select new
                       {
                           SlId = p.SlId,
                           SupplierTypeName = p.SupplierType.SupplierTypeName,
                           SlrName = p.SlrName,
                           SlDescribe = p.SlDescribe,
                           SlContacts = p.SlContacts,
                           SlIphone = p.SlIphone,
                           SlAddress = p.SlAddress

                       });
            return obj;

        }

        /// <summary>
        /// 获取数据表的总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows()
        {
            StorageEntities entity = new StorageEntities();
            return entity.Supplier.Count();
        }


        /// <summary>
        /// 供应商管理分页类查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList PageListDemo(int pageIndex=1, int PageSize=5,string SlrName="")
        {
            StorageEntities entity = new StorageEntities();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in entity.Supplier
                      where p.SlrName.Contains(SlrName)
                      orderby p.SlId
                      select new
                      {
                          SlId = p.SlId,
                          SupplierTypeName = p.SupplierType.SupplierTypeName,
                          SlrName = p.SlrName,
                          SlDescribe = p.SlDescribe,
                          SlContacts = p.SlContacts,
                          SlIphone = p.SlIphone,
                          SlAddress = p.SlAddress
                      };
            //设置分页数据
            list.DataList = obj.Skip((pageIndex-1)*PageSize).Take(PageSize);

            //设置总行数
            list.PageCount = obj.Count();
            return list;
        }
    }
}
