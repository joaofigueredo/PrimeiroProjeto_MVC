using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroProjeto_MVC.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage ="Informe o nome do lanche!")]
        [StringLength(100,MinimumLength = 10, ErrorMessage ="O Maximo de caracteres é 100 e o minimo é 10")]
        [Display(Name ="Nome do Lanche")]
        public string NomeLanche{ get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche!")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O Maximo de caracteres é 100 e o minimo é 10")]
        [Display(Name = "descrição curta do Lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche!")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O Maximo de caracteres é 100 e o minimo é 10")]
        [Display(Name = "Descrição detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O Maximo de caracteres é 200")]
        public string ImagemUrl{ get; set; }

        [Display(Name = "Caminho Imagem pequena")]
        [StringLength(200, ErrorMessage = "O Maximo de caracteres é 200")]
        public string ImagemThumbnailUrl{ get; set; }

        [Display(Name="Lanche Preferido")]
        public bool IsLanchePreferido{ get; set; }
        [Display(Name ="Estoque")]
        public bool EmEstoque{ get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}