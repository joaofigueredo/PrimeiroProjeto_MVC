using Microsoft.AspNetCore.Mvc;

namespace PrimeiroProjeto_MVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
