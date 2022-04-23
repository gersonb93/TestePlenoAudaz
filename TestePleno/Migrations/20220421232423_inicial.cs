using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestePleno.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fares",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OperatorId = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "operators",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operators", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fares");

            migrationBuilder.DropTable(
                name: "operators");
        }
    }
}
