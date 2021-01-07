using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.MaBLL;
using Git.Storage.Common.Excel;
//using Git.Storage.Common.Excel;
using Models;

namespace Storage.Controllers.Ma
{
    public class MaController : Controller
    {
        //跳转主页
        public ActionResult Index()
        {
            return Redirect("Ma/index.html");
        }
        public ActionResult Index1()
        {
            return View();
        }
        //查询库存清单
        public ActionResult WhAll(int PageIndex, int PageSize, int typeid, string name)
        {
            return Json(WarehousingManager.WhAll(PageIndex, PageSize, typeid, name), JsonRequestBehavior.AllowGet);
        }
        //查询所有入库类型
        public ActionResult WsTypeAll()
        {
            return Json(WareStateTypeManager.WsTypeAll(), JsonRequestBehavior.AllowGet);
        }

        //库存导出Excel
        public string Excel(int typeid, string cname)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("序号 "));
            dt.Columns.Add(new DataColumn("供应商名称"));
            dt.Columns.Add(new DataColumn("产品名称"));
            dt.Columns.Add(new DataColumn("入库类别"));
            dt.Columns.Add(new DataColumn("供应商地址"));
            dt.Columns.Add(new DataColumn("产品数量"));
            dt.Columns.Add(new DataColumn("入库时间"));
            List<Warehousing> list = WarehousingManager.Excel(typeid, cname);
            foreach (var item in list)
            {
                DataRow row = dt.NewRow();
                row[0] = item.Wid;
                row[1] = item.Supplier.SlTypeId;
                row[2] = item.Product.PName;
                row[3] = item.WareStateType.TName;
                row[4] = item.Supplier.SlAddress;
                row[5] = item.Product.PCount;
                row[6] = item.time;
                dt.Rows.Add(row);
            }
            var name = string.Format("库存清单报表{0}.xls", DateTime.Now.ToString("yyyyMMddHHmmss"));
            string path = Server.MapPath("~/Excel/");
            var pathname = string.Format("/Excel/{0}", name);
            //AsposeExcel excel = new AsposeExcel(System.IO.Path.Combine(path, name), "");
            //excel.DatatableToExcel(dt, "库存清单报表", "库存清单报表");
            FileStream fs = new FileStream(System.IO.Path.Combine(path, name), FileMode.Open, FileAccess.Read);
            File(fs, "application/vnd.ms-excel", name);
            fs.Close();
            return pathname;
        }

        //货品查询
        public ActionResult ProductAll(int PageIndex, int PageSize, string pname) {
           
            return Json(ProductManager.ProductAll(PageIndex, PageSize, pname), JsonRequestBehavior.AllowGet);
        }

        public string ProductExcel(string pname)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("产品编号 "));
            dt.Columns.Add(new DataColumn("产品名称"));
            dt.Columns.Add(new DataColumn("产品类型"));
            dt.Columns.Add(new DataColumn("规格"));
            dt.Columns.Add(new DataColumn("库存数"));
            dt.Columns.Add(new DataColumn("客户名称"));

            List<Product> list = ProductManager.PrList(pname);
            foreach (var item in list)
            {
                DataRow row = dt.NewRow();
                row[0] = item.PId;
                row[1] = item.PName;
                row[2] = item.ProductCategory.PcName;
                row[3] = item.Pspecifications;
                row[4] = item.PCount;
                row[5] = item.Customer.CtName;
                
                dt.Rows.Add(row);
            }
          
            var name = string.Format("货品清单报表{0}.xls", DateTime.Now.ToString("yyyyMMddHHmmss"));
            string path = Server.MapPath("~/Excel/");
            var pathname = string.Format("/Excel/{0}", name);
            //AsposeExcel excel = new AsposeExcel(System.IO.Path.Combine(path, name), "");
            //excel.DatatableToExcel(dt, "货品清单报表", "货品清单报表");
            FileStream fs = new FileStream(System.IO.Path.Combine(path, name), FileMode.Open, FileAccess.Read);
            File(fs, "application/vnd.ms-excel", name);
            fs.Close();
            return pathname;
        }
        //查询出库表
        public ActionResult DeliveryAll(int PageIndex,int PageSize,int Day) {

            return Json(DeliveryManager.DeliveryAll(PageIndex,PageSize,Day),JsonRequestBehavior.AllowGet);
        }

        //查询排行前五
        public ActionResult paihang(int Day) {
            return Json(DeliveryManager.PaiHang(Day), JsonRequestBehavior.AllowGet);
        }


    }
}