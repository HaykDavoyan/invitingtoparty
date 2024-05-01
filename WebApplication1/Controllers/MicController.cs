using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
