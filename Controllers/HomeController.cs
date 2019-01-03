
using Microsoft.AspNetCore.Mvc;
namespace aspnetcorescratch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}