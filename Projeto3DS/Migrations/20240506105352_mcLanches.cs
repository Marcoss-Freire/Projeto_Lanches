using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class mcLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    categoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    categoriaNome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "longtext", nullable: true),
                    lanche = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.categoriaId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lanche",
                columns: table => new
                {
                    lancheId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descricao_curta = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    descricao_detalhada = table.Column<string>(type: "longtext", nullable: true),
                    emEstoque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    imagemURL = table.Column<string>(type: "longtext", nullable: true),
                    lanchePreferido = table.Column<string>(type: "longtext", nullable: true),
                    categoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanche", x => x.lancheId);
                    table.ForeignKey(
                        name: "FK_Lanche_Categoria_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "Categoria",
                        principalColumn: "categoriaId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Lanche_categoriaId",
                table: "Lanche",
                column: "categoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lanche");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
