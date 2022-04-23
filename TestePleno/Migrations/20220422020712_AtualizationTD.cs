using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestePleno.Migrations
{
    public partial class AtualizationTD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DtCadastro",
                table: "fares",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtCadastro",
                table: "fares");
        }
    }
}
