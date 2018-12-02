using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC.Infrastructure.Migrations
{
    public partial class configuraProfissao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Profissao",
                type: "varchar (200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (100)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Profissao",
                type: "varchar (1000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (200)");

            migrationBuilder.AlterColumn<string>(
                name: "CBO",
                table: "Profissao",
                type: "varchar (200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Profissao",
                type: "varchar (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (200)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Profissao",
                type: "varchar (200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (1000)");

            migrationBuilder.AlterColumn<string>(
                name: "CBO",
                table: "Profissao",
                type: "varchar (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (200)");
        }
    }
}
