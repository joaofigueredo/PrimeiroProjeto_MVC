using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroProjeto_MVC.Migrations
{
    /// <inheritdoc />
    public partial class EditarCaminhos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, '../../wwwroot/images/xsalada.webp', 'https://user-images.githubusercontent.com/62410725/227782170-aaefef2c-e3aa-43c8-9e0f-96c9fda02869.jpg')");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, '../../wwwroot/images/Sanduiche-natural.png', 'https://user-images.githubusercontent.com/62410725/227781780-dcc03db6-5ac9-42a5-b574-491095ad8575.png')");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, '../../wwwroot/images/x-burger.jpg', 'https://user-images.githubusercontent.com/62410725/227781873-1e9dfc46-0a11-4bc2-b2fb-485e3b21d112.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
