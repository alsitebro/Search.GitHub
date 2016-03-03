using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Search.GitHub.Api;
using Search.GitHub.Models;

namespace Search.GitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserSearchRequest request)
        {
            if (!ModelState.IsValid) return RedirectToAction("Index");
            var client = new Client();
            request.User = client.GetUser(request.Name);
            return View(request);
        }
    }
}