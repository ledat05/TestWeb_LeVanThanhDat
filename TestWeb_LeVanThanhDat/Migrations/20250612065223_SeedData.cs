using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWeb_LeVanThanhDat.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, null, 700m, 1, "TÂM" },
                    { 2, null, 800m, 1, "ASP.NET" },
                    { 3, null, 750m, 1, "PHP" },
                    { 4, null, 600m, 1, "JavaScript" },
                    { 5, null, 900m, 1, "Trình là gì ?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
