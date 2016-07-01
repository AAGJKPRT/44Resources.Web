using _44Resources.DataContract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace _44Resources.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Default controller...
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult login()
        {
            return View();
        }

        public ActionResult newassociate()
        {
            return View();
        }
        public ActionResult Associates()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(BusinessAssociate businessAssociate)
        {
            //string json = "";//http://localhost:1494/Service1.svc
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //string address = @"!@#$%, , , ,!@#$%^ ^&*()_+";
            //string Paddress = @"$%,,,,187/60-c,^&*()_+";
            //string Param = "Test user,Mulayam%20singh," + address + ",2,4,110053," + Paddress + ",2,4,543488,8764678674,1,2,tv%20repair,15,800,3,1,5,9878707870,7570787078,7870787097,7870767097";
            ////Param = Base64Encode(Param);
            //// string requestURL = "http://services.easylabour.com/Service1.svc" + "/InsertLabour/HHAcDa23000091,Labour Name,Father Name,Current Address of the Labour,1,2,110053,PermanentAddress of the labour,1,2,110053,9999543456,1,3,TV,4,780,1,1,5,1234567891,1234567891,1234567891,1234567891";
            //string requestURL = "http://services.easylabour.com/Service1.svc/InsertLabour/" + Param;
            //WebRequest webRequest = WebRequest.Create(requestURL);
            //HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
            //using (var sr = new StreamReader(httpWebResponse.GetResponseStream()))
            //{
            //    json = sr.ReadToEnd();
            //}
            //var jsonObject = js.Deserialize<dynamic>(json);
            return View();
        }
    }
}