using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CVOnline.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesAndAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                column: "CssTemplate",
                value: ".technical-cv { font-family: 'Courier New', monospace; display: flex; color: #008080; background: #f5fafa; } .technical-cv aside { width: 25%; background: #e0ffff; padding: 20px; border-right: 3px solid #008080; } .technical-cv main { width: 75%; padding: 20px; } .technical_cv h1 { font-size: 30px; color: #008080; } .technical-cv .contact { font-size: 14px; line-height: 1.8; } .technical-cv h2 { font-size: 22px; color: #006d5b; margin: 20px 0 10px; background: #e0ffff; padding: 5px; } .technical-cv h3 { font-size: 18px; } .technical-cv ul { list-style-type: circle; margin-left: 20px; }");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                column: "CssTemplate",
                value: ".technical-cv { font-family: 'Courier New', monospace; display: flex; color: #008080; background: #f5fafa; } .technical-cv aside { width: 25%; background: #e0ffff; padding: 20px; border-right: 3px solid #008080; } .technical-cv main { width: 75%; padding: 20px; } .technical-cv h1 { font-size: 30px; color: #008080; } .technical-cv .contact { font-size: 14px; line-height: 1.8; } .technical-cv h2 { font-size: 22px; color: #006d5b; margin: 20px 0 10px; background: #e0ffff; padding: 5px; } .technical-cv h3 { font-size: 18px; } .technical-cv ul { list-style-type: circle; margin-left: 20px; }");
        }
    }
}
