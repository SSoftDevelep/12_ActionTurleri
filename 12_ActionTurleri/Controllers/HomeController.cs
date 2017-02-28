using _12_ActionTurleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_ActionTurleri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        #region Redirect Result Sample
        public ActionResult Index()
        {
            return Redirect("https://www.google.com");
        }

        public RedirectResult Index2()
        {

            return Redirect("/Home/Index");
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("Index2");
        }
        #endregion

        public ActionResult Index4()
        {
            return View();
        }

        public JsonResult Index5()
        {
            Urun urn = new Urun();
            urn.Adi = "Domates";
            urn.Fiyat = 12000;
            urn.ID = 5;
            urn.Aciklama = "Bu bir deneme ürünüdür.";


            /* Json Böyle;
             {
                ID=5,
                Adi:"Domates",
                Fiyat:12000,
                Aciklama:"Bu bir deneme ürünüdür."
             }


            XML Böyle;
            <Urun>
                   <ID>5</ID>
                   <Adi>Domates</Adi>
                   <Fiyat>12000</Fiyat>
                   <Aciklama>Bu bir deneme ürünüdür.<Aciklama>

            </Urun>
             
             */

            return Json(urn, JsonRequestBehavior.AllowGet); // Json > verdigimiz urn nesnesini Json turune donusturur.
        }
        [HttpPost]   //Bu post metodunu ajax kisminda  type: "POST", post ile veri cekmek isteyeni engellemek icin yazdik.
        public JsonResult Index5(int? deger)
        {
            return Json(null);
        }

        #region RedirectToRouteResult
        static List<string> Veriler = new List<string>();
        public ActionResult Sayfamiz()
        {
            ViewBag.Liste = Veriler;

            return View();
        }

        [HttpPost]
        public ActionResult Sayfamiz(string ad, string soyad)
        {
            Veriler.Add(ad + " " + soyad);
            return new RedirectToRouteResult(

                //Home/Sayfamiz?kod=7D84DBF3-094B-4951-8D60-8CEF3FADD0AF
                new System.Web.Routing.RouteValueDictionary(
                    new
                    {
                        action = "Sayfamiz",
                        controller = "Home",
                        kod = Guid.NewGuid().ToString()
                    }));
        }

        #endregion


        //FileResult- FileStreamResult
        public ActionResult Dosyalar()
        {
            return View();
        }

        public FileResult PDFDosyaIndir()
        {
            string DosyaYolu = Server.MapPath("~/Files/git101.pdf");  //dosyanin tam fiziksel adresini verir.

            return new FilePathResult(DosyaYolu,"application/pdf");
        }
    }
}
