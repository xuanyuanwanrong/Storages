using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LiuYingXuan
{
   public class WareHouseService
    {
        public static IQueryable GetWareHouse()
        {
            StorageEntities entity = new StorageEntities();

            var obj = from p in entity.WareHouse select new 
            {
              WhTypeId = p.WhTypeId,
              WhName = p.WhName,
              IsForbidden = p.IsForbidden,
              WhTime = p.WhTime,
              WhStateId = p.WhStateId,
              Stid = p.Stid
            };

            return obj;
        }

        //public List<WareHouse> GetList()
        //{
        //    List<WareHouse> listResult = CacheHelper.Get<List<WareHouse>>(CacheKey.JOOSHOW_LOCATION_CACHE);

        //    if (!listResult.IsNullOrEmpty())
        //    {
        //        return listResult;
        //    }
        //    StorageEntities entity = new StorageEntities();

        //    entity.Where(a => a.IsDelete == (int)EIsDelete.NotDelete);

        //    entity.IncludeAll();

        //    listResult = this.Location.GetList(entity);

        //    if (!listResult.IsNullOrEmpty())
        //    {
        //        StorageProvider storageProvider = new StorageProvider();

        //        List<WareHouse> listStorage = storageProvider.GetList();

        //        listStorage = listStorage.IsNull() ? new List<WareHouse>() : listStorage;

        //        foreach (LocationEntity item in listResult)
        //        {
        //            StorageEntity storage = listStorage.FirstOrDefault(a => a.StorageNum == item.StorageNum);
        //            if (storage != null)
        //            {
        //                item.StorageName = storage.StorageName;
        //            }
        //        }
        //        CacheHelper.Insert(CacheKey.JOOSHOW_LOCATION_CACHE, listResult, null, DateTime.Now.AddHours(6));
        //    }
        //    return listResult;
        //}
    }
}
