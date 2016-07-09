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
            try
            {
                string json = "";//http://services.44resources.com/44Service.svc
                JavaScriptSerializer js = new JavaScriptSerializer();

                businessAssociate.Pincode = businessAssociate.Pincode == null ? "null" : businessAssociate.Pincode;
                businessAssociate.Address = businessAssociate.Address == null ? "null" : businessAssociate.Address;
                businessAssociate.City = businessAssociate.City == null ? "null" : businessAssociate.City;

                string Param = businessAssociate.FirstName + "," + businessAssociate.LastName + "," + businessAssociate.Email
                + "," + businessAssociate.Mobile + "," + businessAssociate.Password + "," + businessAssociate.Address +
                "," + businessAssociate.Pincode + "," + businessAssociate.City;
                //Param = Base64Encode(Param);
                string requestURL = "http://services.44resources.com/44Service.svc/BASignUp/" + Param;
                WebRequest webRequest = WebRequest.Create(requestURL);
                HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
                using (var sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    json = sr.ReadToEnd();
                }
                var jsonObject = js.Deserialize<dynamic>(json);
            }
            catch (Exception ex)
            {
                ex.ToString();
                return View();
            }
            return View();
        }
    }
}