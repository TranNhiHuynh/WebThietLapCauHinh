using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Web.WebPages;
using System.Net.NetworkInformation;
using System.ComponentModel;

namespace Web_ThietLapCauHinh.Controllers
{
    public class HomeController : Controller
    {
        public CauHinhEntities db = new CauHinhEntities();
        public ActionResult PhanHe()
        {
            List<MB_PhanHe> dsPH = db.MB_PhanHe.ToList();

            ViewData["dsPH"] = dsPH;
            return View();
        }
        public ActionResult ThemPhanHe()
        {
            return View();
        }


        public ActionResult XuLiThemPhanHe(FormCollection cl)
        {
            MB_PhanHe ph = new MB_PhanHe();

            ph.Id = int.Parse(cl["id"]);
            ph.MaPhanHe = cl["maPhanHe"];
            ph.TenPhanHe = cl["tenPhanHe"];
            ph.GhiChu = cl["ghiChu"];
            ph.IsHienThi = bool.Parse(cl["isHienThi"]);
            ph.NguoiTao = null;
            ph.NgayTao = DateTime.Now;
            ph.NguoiCapNhat = null;
            ph.NgayCapNhat = DateTime.Now;

            db.MB_PhanHe.Add(ph);
            int kq = db.SaveChanges();          
            return RedirectToAction("PhanHe","Home");
        }
        public ActionResult XoaPhanHe(int key)
        {
            var ph = db.MB_PhanHe.FirstOrDefault(x=> x.Id == key);

            if(ph != null)
            {
                db.MB_PhanHe.Remove(ph);
                db.SaveChanges();
            }
            return Redirect("PhanHe");
        }
        public ActionResult CapNhatPhanHe(int key)
        {
            var ph = db.MB_PhanHe.FirstOrDefault(x => x.Id == key);

            ViewData["ph"] = ph;
            return View();
        }

        public ActionResult XuLiCapNhatPhanHe(FormCollection cl)
        {
            int id = int.Parse(cl["id"]);
            var ph = db.MB_PhanHe.FirstOrDefault(x => x.Id == id);

            ph.MaPhanHe = cl["maPhanHe"];
            ph.TenPhanHe = cl["tenPhanHe"];
            ph.GhiChu = cl["ghiChu"];
            ph.IsHienThi = bool.Parse(cl["isHienThi"]);
            ph.NgayCapNhat = DateTime.Now;
            db.SaveChanges();        
            return Redirect("PhanHe");
        }
    }
}