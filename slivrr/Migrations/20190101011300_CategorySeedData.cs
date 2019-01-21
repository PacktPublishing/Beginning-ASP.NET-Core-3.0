using Microsoft.EntityFrameworkCore.Migrations;

namespace slivrr.Migrations
{
    public partial class CategorySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Used to compute a speed based on time.", "Tachymeter" },
                    { 2, "A stopwatch combined with a display watch.", "Chronograph" },
                    { 3, "A small second hand", "Small Seconds" },
                    { 4, "Manual winding of the timepiece", "Manual Winding" },
                    { 5, "Automatic winding of the timepiece", "Automatic Winding" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
