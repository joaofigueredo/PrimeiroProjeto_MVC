using Microsoft.AspNetCore.Mvc;

namespace PrimeiroProjeto_MVC.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}
