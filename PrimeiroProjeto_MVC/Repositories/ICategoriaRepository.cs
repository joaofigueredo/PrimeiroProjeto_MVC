using PrimeiroProjeto_MVC.Models;


namespace PrimeiroProjeto_MVC.Repositories;
public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}
