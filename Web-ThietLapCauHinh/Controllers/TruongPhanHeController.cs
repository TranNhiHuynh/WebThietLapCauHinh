using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_ThietLapCauHinh.Controllers
{
    public class TruongPhanHeController : Controller
    {
        // GET: TruongPhanHe
        public CauHinhEntities db = new CauHinhEntities();
        public ActionResult TruongPhanHe()
        {
            List<MB_Truong_PhanHe> dsTrPh = db.MB_Truong_PhanHe.ToList();

            ViewData["dsTrPh"] = dsTrPh;
            return View();
        }
        public ActionResult ThemTruongPhanHe()
        {
            List<MB_Truong> dsTr = db.MB_Truong.ToList();
            List<MB_PhanHe> dsPh = db.MB_PhanHe.ToList();

            ViewData["dsTr"] = dsTr;
            ViewData["dsPh"] = dsPh;

            return View();
        }


        public ActionResult XuLiThemTruongPhanHe(FormCollection cl)
        {
            MB_Truong_PhanHe TrPh = new MB_Truong_PhanHe();

            TrPh.Id = int.Parse(cl["id"]);
            TrPh.IDTruong = int.Parse(cl["idTruong"]);
            TrPh.IDPhanHe = int.Parse(cl["idPhanHe"]);
            TrPh.Url = cl["url"];
            TrPh.Url_2 = cl["url2"];
            TrPh.Url_3 = cl["url3"];
            TrPh.UrlSocket = cl["urlsocket"];
            TrPh.SubAPI = cl["subapi"];
            TrPh.SubAPI_2 = cl["subapi2"];
            TrPh.SubAPI_3 = cl["subapi3"];
            TrPh.GhiChu = cl["ghichu"];
            TrPh.Warning_RequireSurvey = cl["warningrequiresurvey"];
            TrPh.FeaturesRequireSurvey = cl["featuresrequiresurvey"];
            TrPh.NguoiTao = null;
            TrPh.NgayTao = DateTime.Now;
            TrPh.NguoiCapNhat = null;
            TrPh.NgayCapNhat = DateTime.Now;

            TrPh.VersionEgovAPI = int.Parse(cl["versionegovapi"]);
            TrPh.UrlPayment = cl["urlpayment"];
            TrPh.VersionStudentAPI = int.Parse(cl["versionstudentapi"]);
            TrPh.WarningMessage = cl["[warningmessage]"];
            TrPh.HasAds = bool.Parse(cl["hasads"].ToString());
            TrPh.WebsiteUrl = cl["websiteurl"];
            TrPh.VersionWeb = int.Parse(cl["versionweb"]);
            TrPh.UseHTMLSalaryView = bool.Parse(cl["usehtmlsalaryview"].ToString());
            db.MB_Truong_PhanHe.Add(TrPh);
            int kq = db.SaveChanges();
            return RedirectToAction("TruongPhanHe", "TruongPhanHe");
        }
        public ActionResult XoaTruongPhanHe(int key)
        {
            var TrPh = db.MB_Truong_PhanHe.FirstOrDefault(x => x.Id == key);

            if (TrPh != null)
            {
                db.MB_Truong_PhanHe.Remove(TrPh);
                db.SaveChanges();
            }
            return Redirect("TruongPhanHe");
        }
        public ActionResult CapNhatTruongPhanHe(int key)
        {
            var TrPh = db.MB_Truong_PhanHe.FirstOrDefault(x => x.Id == key);
             List<MB_Truong> dsTr = db.MB_Truong.ToList();
            List<MB_PhanHe> dsPh = db.MB_PhanHe.ToList();

            ViewData["dsTr"] = dsTr;
            ViewData["dsPh"] = dsPh;

            ViewData["TrPh"] = TrPh;
            return View();
        }

        public ActionResult XuLiCapNhatTruongPhanHe(FormCollection cl)
        {
            int id = int.Parse(cl["id"]);
            var TrPh = db.MB_Truong_PhanHe.FirstOrDefault(x => x.Id == id);
            TrPh.IDTruong = int.Parse(cl["idTruong"]);
            TrPh.IDPhanHe = int.Parse(cl["idPhanHe"]);
            TrPh.Url = cl["url"];
            TrPh.Url_2 = cl["url2"];
            TrPh.Url_3 = cl["url3"];
            TrPh.UrlSocket = cl["urlsocket"];
            TrPh.SubAPI = cl["subapi"];
            TrPh.SubAPI_2 = cl["subapi2"];
            TrPh.SubAPI_3 = cl["subapi3"];
            TrPh.GhiChu = cl["ghichu"];
            TrPh.Warning_RequireSurvey = cl["warningrequiresurvey"];
            TrPh.FeaturesRequireSurvey = cl["featuresrequiresurvey"];
            TrPh.NguoiTao = null;
            TrPh.NgayTao = DateTime.Now;
            TrPh.NguoiCapNhat = null;
            TrPh.NgayCapNhat = DateTime.Now;

            TrPh.VersionEgovAPI = int.Parse(cl["versionegovapi"]);
            TrPh.UrlPayment = cl["urlpayment"];
            TrPh.VersionStudentAPI = int.Parse(cl["versionstudentapi"]);
            TrPh.WarningMessage = cl["[warningmessage]"];
            TrPh.HasAds = bool.Parse(cl["hasads"].ToString());
            TrPh.WebsiteUrl = cl["websiteurl"];
            TrPh.VersionWeb = int.Parse(cl["versionweb"]);
            TrPh.UseHTMLSalaryView = bool.Parse(cl["usehtmlsalaryview"].ToString());
            int kq = db.SaveChanges();
            return Redirect("TruongPhanHe");
        }
    }
}