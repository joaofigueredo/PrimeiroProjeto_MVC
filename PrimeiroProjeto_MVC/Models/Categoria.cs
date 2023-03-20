namespace PrimeiroProjeto_MVC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string  CategoriaNome { get; set; }
        public int Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}