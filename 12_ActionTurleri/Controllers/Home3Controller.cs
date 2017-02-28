using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_ActionTurleri.Controllers
{
    public class Home3Controller : Controller
    {
        //JavaScript Result

        public ActionResult Sayfamiz()
        {
            return View();
        }


        public JavaScriptResult BaslangicMesaji()
        {
            string js = "alert('Hello World')";
            return JavaScript(js);
        }


        public JavaScriptResult jsButtonClick()
        {
            string js = "function button_click() { alert('Hello JsResult')}";
            return JavaScript(js);
        }
    }
}