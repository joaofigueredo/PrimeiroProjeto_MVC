using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto_MVC.Models;
using PrimeiroProjeto_MVC.Repositories.Interfaces;
using PrimeiroProjeto_MVC.ViewModels;
using System.Linq;

namespace PrimeiroProjeto_MVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            
            else
            {
                /*
                if(string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                            .Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                            .OrderBy(l => l.NomeLanche);
                }
                else
                {
                    lanches = _lancheRepository.Lanches
                            .Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                            .OrderBy(l => l.NomeLanche);
                }*/

                lanches = _lancheRepository.Lanches
                            .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                            .OrderBy(c => c.NomeLanche);
                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        }

        public IActionResult Details(int lancheId) 
        {
            var lanche =  _lancheRepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            return View(lanche);
        }
    }
}
