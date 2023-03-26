using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroProjeto_MVC.Migrations
{
    /// <inheritdoc />
    public partial class ConsertoDeImagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, 'C:\\Users\\joaof\\OneDrive\\Documentos\\Projetos c#\\PrimeiroProjeto_MVC\\PrimeiroProjeto_MVC\\wwwroot\\images\\cheesesalada.webp', '~/images/xsalada.webp')");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, 'C:\\Users\\joaof\\OneDrive\\Documentos\\Projetos c#\\PrimeiroProjeto_MVC\\PrimeiroProjeto_MVC\\wwwroot\\images\\Sanduiche-natural.png', '~/images/Sanduiche-natural.png')");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = REPLACE(ImagemUrl, 'C:\\Users\\joaof\\OneDrive\\Documentos\\Projetos c#\\PrimeiroProjeto_MVC\\PrimeiroProjeto_MVC\\wwwroot\\images\\x-burger.jpg', '~/images/x-burger.jpg')");
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
