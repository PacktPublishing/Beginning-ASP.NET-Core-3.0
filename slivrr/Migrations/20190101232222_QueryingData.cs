using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace slivrr.Migrations
{
    public partial class QueryingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ItemId = table.Column<int>(nullable: false),
                    Item_Price = table.Column<decimal>(type: "Money", nullable: false),
                    Item_QuantityInStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesToProducts",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesToProducts", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoriesToProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesToProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ItemId", "Name", "Item_Price", "Item_QuantityInStock" },
                values: new object[,]
                {
                    { 1, "Dark Side of the Moon", 1, "Omega Speedmaster", 8895.0m, 5 },
                    { 2, "Carrera Calibre 16", 2, "TAG Heuer", 3360.0m, 8 },
                    { 3, "Unico Titanium 42mm", 3, "Hublot Big Bang", 17800.0m, 1 },
                    { 4, "BR V2-94 Garde-Cotes", 4, "Bell & Ross", 4300.0m, 3 }
                });

            migrationBuilder.InsertData(
                table: "CategoriesToProducts",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 5 },
                    { 3, 2 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesToProducts_CategoryId",
                table: "CategoriesToProducts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesToProducts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
