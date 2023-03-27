using Microsoft.Identity.Client;
using PrimeiroProjeto_MVC.Models;

namespace PrimeiroProjeto_MVC.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
