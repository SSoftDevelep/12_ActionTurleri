using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_ActionTurleri.Controllers
{
    public class Home2Controller : Controller
    {

        //PartialView Result

        public ActionResult Anasayfa()
        {
            return View();
        }

        public PartialViewResult GetirKategoriPartial()
        {
            return PartialView("_KategorilerPartial");
        }

        public PartialViewResult GetirKategoriPartial2()
        {


            List<string> kategoriler = new List<string>()
                {
                    "Teknoloji",
                    "Araclar",
                    "Temizlik",
                    "Teknoloji",
                    "Gida",
                    "Giyim"
                };


        
            return PartialView("_KategorilerPartial2",kategoriler);
    }
}
}