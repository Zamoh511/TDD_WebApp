using Foursquare.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TDD_WebApp.Models;

namespace TDD_WebApp.Controllers
{
    public class HomeController : Controller
    {
        string apiUrl = ConfigurationManager.AppSettings["APIUrl"].ToString();
        //public ActionResult Index()
        //{
        //    return View();
        //}

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
        
        // GET: Transact
        public ActionResult Index()
        {
            string param = "Durban";
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var response = client.GetAsync(apiUrl + "/api/Home/GetImageAsync"/* + param*/).Result;

            string returnValue = response.Content.ReadAsStringAsync().Result;
            string Premium = JsonConvert.DeserializeObject<string>(returnValue);
            return Json(Premium, JsonRequestBehavior.AllowGet);
            //return View();
        }

        // GET:Transactions/Details/5
        public ActionResult GetLocatonsList(FoursquareLocationVM foursquareLocation)
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var content = Newtonsoft.Json.JsonConvert.SerializeObject(foursquareLocation);
            var response = client.PostAsync(apiUrl + "/api/Home/GetLoationDetailsAsync", new StringContent(content, Encoding.UTF8, "application/json")).Result;
            string returnValue = response.Content.ReadAsStringAsync().Result;
            string Premium = JsonConvert.DeserializeObject<string>(returnValue);
            return Json(Premium, JsonRequestBehavior.AllowGet);

        }

    }
}