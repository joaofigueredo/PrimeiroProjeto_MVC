using Microsoft.EntityFrameworkCore;
using PrimeiroProjeto_MVC.Models;

namespace PrimeiroProjeto_MVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //mapeia a classe, primeiro nome, para a tabela, segundo nome
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}