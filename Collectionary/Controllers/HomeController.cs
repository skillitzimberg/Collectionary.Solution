using Microsoft.AspNetCore.Mvc;
using Collectionary.Models;

namespace Collectionary.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
