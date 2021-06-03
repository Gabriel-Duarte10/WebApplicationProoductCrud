using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationProoductCrud.Data.Migrations
{
    public partial class Fabricas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabricas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeFabri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fabricas");
        }
    }
}
