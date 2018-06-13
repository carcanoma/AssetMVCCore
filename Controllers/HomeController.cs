using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssetMVCCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AssetStoreContext context = HttpContext.RequestServices.GetService(typeof(AssetStoreContext)) as AssetStoreContext;

            return View(context.GetAllAssets());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
