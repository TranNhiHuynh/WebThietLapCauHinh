using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace Web_ThietLapCauHinh.Controllers
{
    public class TruongController : Controller
    {
        // GET: Truong
        public CauHinhEntities db = new CauHinhEntities();
        public ActionResult Truong()
        {
            List<MB_Truong> dsTR = db.MB_Truong.ToList();

            ViewData["dsTR"] = dsTR;
            return View();
        }
        public ActionResult ThemTruong()
        {
            return View();
        }


        public ActionResult XuLiThemTruong(FormCollection cl)
        {
            MB_Truong ph = new MB_Truong();

            ph.Id = int.Parse(cl["id"]);
            ph.MaTruong = cl["maTruong"];
            ph.TenTruong = cl["tenTruong"];
            ph.TruocThuocBo = cl["ghiChu"];
            ph.DuongDanLogo = cl["logo"];
            ph.IsHienThi = bool.Parse(cl["isHienThi"].ToString());
            ph.IsSuDungRieng = bool.Parse(cl["isSuDungRieng"]);
            ph.ThongTinRieng = cl["thongTinRieng"];
            ph.GhiChu = cl["ghiChu"];
            ph.Loai = null;
            ph.NguoiTao = null;
            ph.NgayTao = DateTime.Now;
            ph.NguoiCapNhat = null;
            ph.NgayCapNhat = DateTime.Now;
            db.MB_Truong.Add(ph);
            int kq = db.SaveChanges();
            return RedirectToAction("Truong", "Truong");
        }
        public ActionResult XoaTruong(int key)
        {
            var tr = db.MB_Truong.FirstOrDefault(x => x.Id == key);

            if (tr != null)
            {
                db.MB_Truong.Remove(tr);
                db.SaveChanges();
            }
            return Redirect("Truong");
        }
        public ActionResult CapNhatTruong(int key)
        {
            var tr = db.MB_Truong.FirstOrDefault(x => x.Id == key);

            ViewData["tr"] = tr;
            return View();
        }

        public ActionResult XuLiCapNhatTruong(FormCollection cl)
        {
            int id = int.Parse(cl["id"]);
            var ph = db.MB_Truong.FirstOrDefault(x => x.Id == id);
            ph.MaTruong = cl["maPhanHe"];
            ph.TenTruong = cl["tenPhanHe"];
            ph.TruocThuocBo = cl["ghiChu"];
            ph.DuongDanLogo = cl["logo"];
            ph.IsHienThi = bool.Parse(cl["isHienThi"].ToString());
            ph.IsSuDungRieng = bool.Parse(cl["isSuDungRieng"]);
            ph.ThongTinRieng = cl["thongTinRieng"];
            ph.GhiChu = cl["ghiChu"];
            ph.Loai = null;
            ph.NguoiTao = null;
            ph.NgayTao = DateTime.Now;
            ph.NguoiCapNhat = null;
            ph.NgayCapNhat = DateTime.Now;
            int kq = db.SaveChanges();
            return Redirect("Truong");
        }
    }
}