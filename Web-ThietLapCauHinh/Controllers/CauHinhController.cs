using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_ThietLapCauHinh.Controllers
{
    public class CauHinhController : Controller
    {
        // GET: CauHinh
        public CauHinhEntities db = new CauHinhEntities();
        public ActionResult CauHinh()
        {
            List<MB_Truong> dsTr = db.MB_Truong.ToList();
            List<MB_PhanHe> dsPh = db.MB_PhanHe.ToList();
            List<MB_Truong_PhanHe> dsTrPh = db.MB_Truong_PhanHe.ToList();

            ViewData["dsTr"] = dsTr;
            ViewData["dsPh"] = dsPh;
            ViewData["dsTrPh"] = dsTrPh;

            return View();
        }
    }
}