using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto_MVC.Models;
using PrimeiroProjeto_MVC.Repositories.Interfaces;
using PrimeiroProjeto_MVC.ViewModels;
using System.Diagnostics;

namespace PrimeiroProjeto_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
        }
        public IActionResult Demo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}