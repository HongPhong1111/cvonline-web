using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVOnline.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 1,
                column: "PreviewImageUrl",
                value: "/images/templates/simple.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 1,
                column: "PreviewImageUrl",
                value: "/images/templates/simple.jpg");
        }
    }
}
