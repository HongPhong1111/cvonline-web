using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVOnline.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoUrlToCV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "CVs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "CVs");
        }
    }
}
