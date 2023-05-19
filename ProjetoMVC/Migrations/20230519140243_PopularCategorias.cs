using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) "
                +  "VALUES('Normal','Lanche feito com ingredientes industrializados')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) "
                + "VALUES('Natural','Lanche feito com ingredientes naturais, ingtegrais e frescos')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
