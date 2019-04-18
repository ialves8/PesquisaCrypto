using Microsoft.EntityFrameworkCore.Migrations;

namespace PesquisaCrypto.Migrations
{
    public partial class UpdatePropertyMoedas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Moedas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Moedas",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
