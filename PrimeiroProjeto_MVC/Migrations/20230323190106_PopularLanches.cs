using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroProjeto_MVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Lanches(" +
                    "CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl," +
                    " ImagemURl, IsLanchePreferido, NomeLanche, Preco)" +
                    " VALUES(" +
                        "1," +
                        "'Pão Hamburger, ovo, presunto, queijo e batata palha'," +
                        "'Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira acompanhado com batata palha'," +
                        "1," +
                        "'cheesesalada.webp'," +
                        "'C:\\Users\\joaof\\OneDrive\\Documentos\\Projetos c#\\PrimeiroProjeto_MVC\\PrimeiroProjeto_MVC\\wwwroot\\images\\cheesesalada.webp'," +
                        "0," +
                        "'Cheese Salada'," +
                        "15.00)");

            migrationBuilder.Sql(
                "INSERT INTO Lanches(" +
                    "CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl," +
                    " ImagemURl, IsLanchePreferido, NomeLanche, Preco)" +
                    " VALUES(" +
                        "2," +
                        "'Pão Integral, frango, cenoura ralada, queijo cottage, tomate'," +
                        "'Delicioso pão integral com frango; cenoura e queijo cottage de primeira e tomate'," +
                        "1," +
                        "'Sanduiche-natural.png'," +
                        "'C:\\Users\\joaof\\OneDrive\\Documentos\\Projetos c#\\PrimeiroProjeto_MVC\\PrimeiroProjeto_MVC\\wwwroot\\images\\Sanduiche-natural.png'," +
                        "0," +
                        "'Sanduiche Natural'," +
                        "25.00)");

            migrationBuilder.Sql(
                "INSERT INTO Lanches(" +
                    "CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl," +
                    " ImagemURl, IsLanchePreferido, NomeLanche, Preco)" +
                    " VALUES(" +
                        "1," +
                        "'Pão de Hamburger, carne de hamburger industiral, ovo, queijo, presunto, alface e tomate'," +
                        "'Delicioso pão de hambúrger com carne; ovo; queijo; presunto; alface e tomate frescos'," +
                        "1," +
                        "'x-burger.jpg'," +
                        "'C:\\Users\\joaof\\OneDrive\\Documentos\\Projetos c#\\PrimeiroProjeto_MVC\\PrimeiroProjeto_MVC\\wwwroot\\images\\x-burger.jpg'," +
                        "1," +
                        "'X-Burger'," +
                        "20.00)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches ");
        }
    }
}
