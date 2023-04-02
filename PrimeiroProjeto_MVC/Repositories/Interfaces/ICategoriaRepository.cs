using PrimeiroProjeto_MVC.Models;


namespace PrimeiroProjeto_MVC.Repositories.Interfaces;
public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}
