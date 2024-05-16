using Microsoft.EntityFrameworkCore.Migrations;
using Mysqlx.Crud;
using Projeto3DS.Models;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class PopCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Categoria(CategoriaNome, descricao) values ('normal','lanches feitpo com ingredientes normais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categoria");
        }
    }
}
