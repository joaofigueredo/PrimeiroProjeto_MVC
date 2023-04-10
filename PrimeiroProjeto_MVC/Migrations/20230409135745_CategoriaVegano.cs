using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroProjeto_MVC.Migrations
{
    /// <inheritdoc />
    public partial class CategoriaVegano : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               "INSERT INTO Lanches(" +
                   "CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl," +
                   " ImagemURl, IsLanchePreferido, NomeLanche, Preco)" +
                   " VALUES(" +
                       "3," +
                       "'Pão de centeio, maionese vegetal, alface e pepino'," +
                       "'Delicioso pão de centeio com maionese vegetal; alface e pepino fresco'," +
                       "1," +
                       "'vegano.jpeg'," +
                       "'https://user-images.githubusercontent.com/62410725/230776620-b3bf9926-dcef-4cc9-9576-569a86139066.jpg'," +
                       "0," +
                       "'Vegano'," +
                       "40.00)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches ");
        }
    }
}
