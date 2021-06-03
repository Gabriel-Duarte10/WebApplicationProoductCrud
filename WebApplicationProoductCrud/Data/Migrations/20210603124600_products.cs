using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationProoductCrud.Data.Migrations
{
    public partial class products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeProd = table.Column<string>(nullable: false),
                    NomeFabri = table.Column<string>(nullable: false),
                    CategoryProd = table.Column<string>(nullable: false),
                    QtdProd = table.Column<int>(nullable: false),
                    ValueProd = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
