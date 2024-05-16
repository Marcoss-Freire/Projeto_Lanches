using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class Lanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Lanche(descricao_curta,descricao_detalhada,emEstoque,lancheId,nome,preco,imagemURL,lanchePreferido) values ('Lanche muito gostoso','Lanche feito com as melhores carnes do mercados com alface e tomate frescos',1,1,'555Deli',50.00,'ceily.jpg','Sim')");
            migrationBuilder.Sql("Insert Into Lanche(descricao_curta,descricao_detalhada,emEstoque,lancheId,nome,preco,imagemURL,lanchePreferido) values ('Lanche muito suculento','Lanche feito com os melhores alface e tomate',1,2,'100Condi',60.00, 'max.jpg','Nao')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Lanche");
        }
    }
}
