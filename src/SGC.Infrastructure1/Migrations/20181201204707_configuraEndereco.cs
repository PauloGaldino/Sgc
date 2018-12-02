using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC.Infrastructure.Migrations
{
    public partial class configuraEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                type: "varchar (200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Endereco",
                type: "char (2)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Endereco",
                type: "varchar (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "varchar (200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Endereco",
                type: "varchar (15)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "varchar (200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar (200)");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char (2)");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar (100)");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar (200)");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar (15)");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar (200)");
        }
    }
}
