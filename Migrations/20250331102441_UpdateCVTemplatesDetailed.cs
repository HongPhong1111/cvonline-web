using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVOnline.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCVTemplatesDetailed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".simple-cv { font-family: Arial, sans-serif; color: #333; padding: 20px; } .simple-cv h1 { font-size: 28px; color: #000; } .simple-cv h2 { font-size: 20px; color: #555; margin-top: 15px; } .simple-cv hr { border: 1px solid #ccc; }", "<div class=\"simple-cv\"><h1>{FullName}</h1><p>{Email} | {PhoneNumber} | {Address}</p><hr><h2>Kinh Nghiệm Làm Việc</h2><p>Nhập kinh nghiệm của bạn tại đây...</p><h2>Học Vấn</h2><p>Nhập thông tin học vấn tại đây...</p></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".professional-cv { font-family: 'Times New Roman', serif; color: #1e3a8a; padding: 25px; } .professional-cv header { border-bottom: 2px solid #1e3a8a; margin-bottom: 20px; } .professional-cv h1 { font-size: 30px; } .professional-cv h2 { font-size: 22px; color: #1e3a8a; } .professional-cv ul { list-style-type: disc; margin-left: 20px; }", "<div class=\"professional-cv\"><header><h1>{FullName}</h1><p>{Email} | {PhoneNumber}</p></header><section><h2>Học Vấn</h2><p>Nhập thông tin học vấn...</p></section><section><h2>Kinh Nghiệm</h2><p>Nhập kinh nghiệm làm việc...</p></section><section><h2>Kỹ Năng</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".creative-cv { font-family: 'Helvetica', sans-serif; color: #2f4f4f; background: #f0f8ff; padding: 20px; border-radius: 10px; } .creative-cv h1 { font-size: 32px; color: #ff4500; } .creative-cv h2 { font-size: 20px; color: #4682b4; } .creative-cv ul { list-style-type: square; margin-left: 25px; }", "<div class=\"creative-cv\"><h1>{FullName}</h1><p>{Email} - {PhoneNumber} - {Address}</p><div class=\"skills\"><h2>Kỹ Năng</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></div><div class=\"experience\"><h2>Kinh Nghiệm</h2><p>Nhập kinh nghiệm tại đây...</p></div></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".timeline-cv { font-family: 'Verdana', sans-serif; color: #333; padding: 20px; } .timeline-cv h1 { font-size: 28px; color: #d2691e; } .timeline-cv h2 { font-size: 20px; } .timeline-cv .timeline { margin-top: 20px; } .timeline-cv .event { margin: 10px 0; } .timeline-cv .event span { display: inline-block; width: 100px; color: #ff8c00; font-weight: bold; }", "<div class=\"timeline-cv\"><h1>{FullName}</h1><p>{Email} | {PhoneNumber}</p><div class=\"timeline\"><h2>Hành Trình</h2><div class=\"event\"><span>20XX - 20XX</span><p>Nhập sự kiện tại đây...</p></div><div class=\"event\"><span>20XX - Hiện tại</span><p>Nhập sự kiện tại đây...</p></div></div></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".modern-cv { font-family: 'Arial', sans-serif; display: flex; color: #4b0082; } .modern-cv aside { width: 30%; background: #e6e6fa; padding: 20px; } .modern-cv main { width: 70%; padding: 20px; } .modern-cv h1 { font-size: 26px; } .modern-cv h2 { font-size: 20px; color: #483d8b; }", "<div class=\"modern-cv\"><aside><h1>{FullName}</h1><p>{Email}<br>{PhoneNumber}<br>{Address}</p></aside><main><h2>Kinh Nghiệm</h2><p>Nhập kinh nghiệm tại đây...</p><h2>Kỹ Năng</h2><p>Nhập kỹ năng tại đây...</p></main></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".minimalist-cv { font-family: 'Georgia', serif; color: #666; padding: 20px; } .minimalist-cv h1 { font-size: 30px; color: #333; border-bottom: 1px solid #999; } .minimalist-cv h2 { font-size: 18px; margin-top: 15px; }", "<div class=\"minimalist-cv\"><h1>{FullName}</h1><p>{Email} | {PhoneNumber}</p><h2>Kinh Nghiệm</h2><p>Nhập kinh nghiệm tại đây...</p><h2>Học Vấn</h2><p>Nhập học vấn tại đây...</p></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".classic-cv { font-family: 'Garamond', serif; color: #8b4513; padding: 25px; } .classic-cv h1 { font-size: 32px; text-align: center; } .classic-cv h2 { font-size: 22px; margin-top: 20px; }", "<div class=\"classic-cv\"><h1>{FullName}</h1><p>{Email} | {PhoneNumber} | {Address}</p><h2>Học Vấn</h2><p>Nhập học vấn tại đây...</p><h2>Kinh Nghiệm</h2><p>Nhập kinh nghiệm tại đây...</p></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".corporate-cv { font-family: 'Calibri', sans-serif; color: #000080; padding: 20px; } .corporate-cv header { background: #f0f0f0; padding: 10px; } .corporate-cv h1 { font-size: 28px; } .corporate-cv h2 { font-size: 20px; color: #191970; }", "<div class=\"corporate-cv\"><header><h1>{FullName}</h1><p>{Email} | {PhoneNumber}</p></header><section><h2>Mục Tiêu Nghề Nghiệp</h2><p>Nhập mục tiêu tại đây...</p></section><section><h2>Kinh Nghiệm</h2><p>Nhập kinh nghiệm tại đây...</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".academic-cv { font-family: 'Bookman Old Style', serif; color: #800000; padding: 20px; } .academic-cv h1 { font-size: 30px; } .academic-cv h2 { font-size: 20px; color: #8b0000; margin-top: 15px; }", "<div class=\"academic-cv\"><h1>{FullName}</h1><p>{Email} | {PhoneNumber} | {Address}</p><h2>Học Vấn</h2><p>Nhập học vấn tại đây...</p><h2>Ấn Phẩm</h2><p>Nhập ấn phẩm hoặc nghiên cứu tại đây...</p></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".technical-cv { font-family: 'Courier New', monospace; display: flex; color: #008080; } .technical-cv aside { width: 25%; background: #e0ffff; padding: 15px; } .technical-cv main { width: 75%; padding: 15px; } .technical-cv h1 { font-size: 26px; } .technical-cv h2 { font-size: 20px; color: #006d5b; } .technical-cv ul { list-style-type: circle; }", "<div class=\"technical-cv\"><aside><h1>{FullName}</h1><p>{Email}<br>{PhoneNumber}</p></aside><main><h2>Kỹ Năng Kỹ Thuật</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul><h2>Dự Án</h2><p>Nhập dự án tại đây...</p></main></div>" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".simple { color: black; }", "<div>Simple HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".professional { color: blue; }", "<div>Professional HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".creative { color: green; }", "<div>Creative HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".timeline { color: orange; }", "<div>Timeline HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".modern { color: purple; }", "<div>Modern HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".minimalist { color: gray; }", "<div>Minimalist HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".classic { color: brown; }", "<div>Classic HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".corporate { color: navy; }", "<div>Corporate HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".academic { color: maroon; }", "<div>Academic HTML Template</div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".technical { color: teal; }", "<div>Technical HTML Template</div>" });
        }
    }
}
