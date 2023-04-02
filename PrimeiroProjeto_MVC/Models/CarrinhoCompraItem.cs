using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroProjeto_MVC.Models
{
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; } //cria uma chave estrangeira
        public int Quantidade { get; set; }
        
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
