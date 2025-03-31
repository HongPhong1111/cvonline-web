using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVOnline.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNewImageForMau : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 2,
                column: "PreviewImageUrl",
                value: "/images/templates/professional.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 3,
                column: "PreviewImageUrl",
                value: "/images/templates/creative.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 4,
                column: "PreviewImageUrl",
                value: "/images/templates/timeline.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 5,
                column: "PreviewImageUrl",
                value: "/images/templates/modern.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 6,
                column: "PreviewImageUrl",
                value: "/images/templates/minimalist.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 7,
                column: "PreviewImageUrl",
                value: "/images/templates/classic.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 8,
                column: "PreviewImageUrl",
                value: "/images/templates/corporate.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 9,
                column: "PreviewImageUrl",
                value: "/images/templates/academic.png");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                column: "PreviewImageUrl",
                value: "/images/templates/technical.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 2,
                column: "PreviewImageUrl",
                value: "/images/templates/professional.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 3,
                column: "PreviewImageUrl",
                value: "/images/templates/creative.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 4,
                column: "PreviewImageUrl",
                value: "/images/templates/timeline.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 5,
                column: "PreviewImageUrl",
                value: "/images/templates/modern.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 6,
                column: "PreviewImageUrl",
                value: "/images/templates/minimalist.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 7,
                column: "PreviewImageUrl",
                value: "/images/templates/classic.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 8,
                column: "PreviewImageUrl",
                value: "/images/templates/corporate.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 9,
                column: "PreviewImageUrl",
                value: "/images/templates/academic.jpg");

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                column: "PreviewImageUrl",
                value: "/images/templates/technical.jpg");
        }
    }
}
