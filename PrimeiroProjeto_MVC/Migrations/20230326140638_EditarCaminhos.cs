using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroProjeto_MVC.Migrations
{
    /// <inheritdoc />
    public partial class EditarCaminhos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, '~/images/xsalada.webp', '../../wwwroot/images/xsalada.webp')");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, '~/images/Sanduiche-natural.png', '../../wwwroot/images/Sanduiche-natural.png')");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, '~/images/x-burger.jpg', '../../wwwroot/images/x-burger.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
