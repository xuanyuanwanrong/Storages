                                                                                                                           using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Kevin
{
    public class ProductCategoryService
    {
        /// <summary>
        /// 查询产品类别分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns>PageList</returns>
        public static PageList ProductCategoryList(int PageIndex,int PageSize,string PcName)
        {
            StorageEntities entities = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in entities.ProductCategory
                      orderby p.Pcid
                      where p.PcState == 0 && p.PcName.Contains(PcName)
                      select new
                      {
                          Pcid = p.Pcid,
                          PcName = p.PcName,
                          PcRemarks = p.PcRemarks,
                          time = p.time,
                          PcState=p.PcState
                      };
            //设置分页数据
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);


            //设置总行数
            list.PageCount = obj.Count();
            return list;
        }

        /// <summary>
        /// 新增产品类别
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public static int ProductCategoryAdd(ProductCategory pro)
        {
            StorageEntities entities = new StorageEntities();
            entities.ProductCategory.Add(pro);
            return entities.SaveChanges();
        }
        /// <summary>
        /// 删除产品类别（改状态）
        /// </summary>
        /// <param name="PcId"></param>
        /// <returns></returns>
        public static int ProductCategoryDel(int PcId)
        {
            StorageEntities entities = new StorageEntities();
            var obj = (from p in entities.ProductCategory where p.Pcid == PcId select p).First();
            obj.PcState = 1;
            return entities.SaveChanges();
        }
        /// <summary>
        /// 带Pcid查询
        /// </summary>
        /// <param name="Pcid"></param>
        /// <returns></returns>
        public static IQueryable ProductCategoryByPcid(int Pcid)
        {
            StorageEntities entities = new StorageEntities();
            var obj = (from p in entities.ProductCategory where p.Pcid == Pcid select new {
                Pcid = p.Pcid,
                PcName = p.PcName,
                PcRemarks = p.PcRemarks,
                time = p.time,
                PcState = p.PcState
            });
            return obj;
        }
        /// <summary>
        /// 修改产品类别
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public static int ProductCategoryUpd(ProductCategory pro)
        {
            StorageEntities entities = new StorageEntities();
            var obj = (from p in entities.ProductCategory where p.Pcid == pro.Pcid select p).First();
            obj.PcName = pro.PcName;
            obj.PcRemarks = pro.PcRemarks;
            obj.time = DateTime.Now;
            return entities.SaveChanges();
        }

        public static IQueryable GetProductCategory()
        {
            StorageEntities entities = new StorageEntities();
            var obj = from p in entities.ProductCategory
                      where p.PcState == 0
                      select new
                      {
                          Pcid = p.Pcid,
                          PcName =p.PcName
                      };
            return obj;
        }

    }
}
