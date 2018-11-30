using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC.Infrastructure.Migrations
{
    public partial class Configura_Classe_Cliente_Contato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                type: "varchar (20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar 20");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar 200");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contato",
                type: "varchar (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar 100");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "varchar (11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar 11");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                type: "varchar 20",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (20)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                type: "varchar 200",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contato",
                type: "varchar 100",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (100)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "varchar 11",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (11)");
        }
    }
}
