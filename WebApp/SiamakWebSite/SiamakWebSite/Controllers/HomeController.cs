using SiamakWebSite.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SiamakWebSite.Controllers
{
    public class HomeController : Controller
    {
        public int langId = CultureInfo.CurrentCulture.Name.GetCurrentLangValue();
        // GET: Home
        [Route("")]
        [Route("{language?}")]
        public ActionResult Index(string language = "")
        {
            return View();
        }
        public void ChangeLanguage(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = language;
            Response.Cookies.Add(cookie);
        }
    }
}