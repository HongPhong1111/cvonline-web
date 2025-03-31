using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVOnline.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCVTemplatesEnhanced : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".simple-cv { font-family: Arial, sans-serif; color: #333; padding: 20px; background: #f9f9f9; border: 1px solid #ddd; } .simple-cv header { text-align: center; padding-bottom: 20px; border-bottom: 2px solid #3498db; } .simple-cv h1 { font-size: 32px; color: #2c3e50; margin: 0; } .simple-cv .job-title { font-size: 20px; color: #7f8c8d; } .simple-cv .info, .simple-cv .contact { font-size: 14px; margin: 5px 0; } .simple-cv .contact span { margin-right: 5px; color: #3498db; } .simple-cv h2 { font-size: 22px; color: #2980b9; border-bottom: 1px dashed #ddd; margin: 20px 0 10px; } .simple-cv h3 { font-size: 18px; color: #34495e; } .simple-cv ul { list-style-type: disc; margin-left: 20px; } .simple-cv .job, .simple-cv .edu { margin-bottom: 15px; }", "<div class=\"simple-cv\"><header><h1>{FullName}</h1><p class=\"job-title\">{JobTitle}</p><div class=\"info\"><span>Ngày sinh:</span> {BirthDate} | <span>Giới tính:</span> {Gender}</div><div class=\"contact\"><span>📞</span> {PhoneNumber} | <span>✉</span> {Email} | <span>🏠</span> {Address}</div></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Định hướng phát triển sự nghiệp trong lĩnh vực tư vấn, tận dụng 2 năm kinh nghiệm để mang lại giá trị cho công ty và khách hàng.</p></section><section><h2>Kỹ năng</h2><ul><li>Tư vấn khách hàng</li><li>Đàm phán và thuyết phục</li><li>Quản lý thời gian</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Nhân viên tư vấn - Công ty ABC</h3><p>08/2020 - 08/2022</p><ul><li>Tiếp nhận và tư vấn cho 100+ khách hàng mỗi ngày</li><li>Đạt 150% KPI doanh thu</li></ul></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Quản trị Kinh doanh - Tốt nghiệp loại Giỏi</p></div></section><section><h2>Chứng chỉ</h2><p>Chứng chỉ Kỹ năng Bán hàng - 2021</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".professional-cv { font-family: 'Times New Roman', serif; color: #1e3a8a; padding: 25px; background: #fff; box-shadow: 0 2px 5px rgba(0,0,0,0.1); } .professional-cv header { border-bottom: 3px solid #1e3a8a; padding-bottom: 15px; margin-bottom: 20px; } .professional-cv h1 { font-size: 34px; color: #1e3a8a; } .professional-cv .contact { font-size: 14px; } .professional-cv .contact span { color: #1e3a8a; margin-right: 5px; } .professional-cv h2 { font-size: 24px; color: #1e3a8a; margin: 20px 0 10px; background: #f0f4f8; padding: 5px 10px; } .professional-cv h3 { font-size: 18px; } .professional-cv ul { list-style-type: square; margin-left: 20px; }", "<div class=\"professional-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><div class=\"contact\"><span>📞</span> {PhoneNumber} | <span>✉</span> {Email} | <span>🏠</span> {Address} | <span>🌐</span> {Website}</div></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Mong muốn phát triển sự nghiệp trong lĩnh vực tư vấn khách hàng, tận dụng kinh nghiệm để tăng doanh thu và xây dựng mối quan hệ lâu dài với khách hàng.</p></section><section><h2>Kỹ năng</h2><ul><li>Chăm sóc khách hàng</li><li>Tìm kiếm khách hàng tiềm năng</li><li>Giao tiếp chuyên nghiệp</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Tổng đài viên - Công ty ABC</h3><p>08/2020 - 08/2022</p><ul><li>Tư vấn 100+ khách hàng/ngày</li><li>Vượt 150% KPI</li></ul></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Kinh tế - GPA: 3.8/4.0</p></div></section><section><h2>Hoạt động</h2><p>Thành viên CLB Sự kiện - Tổ chức 5 sự kiện lớn với 5000+ người tham gia</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".creative-cv { font-family: 'Helvetica', sans-serif; color: #2f4f4f; background: linear-gradient(to bottom, #f0f8ff, #e6f3fa); padding: 20px; border-radius: 10px; } .creative-cv header { background: #ff4500; color: #fff; padding: 20px; border-radius: 10px 10px 0 0; text-align: center; } .creative-cv h1 { font-size: 36px; margin: 0; } .creative-cv .job-title { font-size: 20px; } .creative-cv .contact span { margin-right: 5px; } .creative-cv h2 { font-size: 22px; color: #4682b4; margin: 20px 0 10px; border-left: 5px solid #ff4500; padding-left: 10px; } .creative-cv .skills-grid { display: grid; grid-template-columns: repeat(3, 1fr); gap: 10px; } .creative-cv .skills-grid span { background: #ffebcd; padding: 5px; text-align: center; border-radius: 5px; } .creative-cv h3 { font-size: 18px; color: #ff4500; } .creative-cv ul { list-style-type: none; margin-left: 0; } .creative-cv ul li:before { content: '★'; color: #ff4500; margin-right: 5px; }", "<div class=\"creative-cv\"><header><h1>{FullName}</h1><p class=\"job-title\">{JobTitle}</p><div class=\"contact\"><span>📞</span> {PhoneNumber} | <span>✉</span> {Email} | <span>🌐</span> {Website}</div></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Sử dụng sự sáng tạo và kỹ năng giao tiếp để xây dựng chiến lược tư vấn hiệu quả, giúp công ty tiếp cận khách hàng mới.</p></section><section><h2>Kỹ năng</h2><div class=\"skills-grid\"><span>Tư vấn</span><span>Thuyết trình</span><span>Sáng tạo</span></div></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Chuyên viên tư vấn - Công ty ABC</h3><p>08/2020 - 08/2022</p><ul><li>Tư vấn giải pháp cho 50+ khách hàng/ngày</li><li>Tăng 200% doanh thu</li></ul></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Thiết kế</p></div></section><section><h2>Danh hiệu</h2><p>Nhân viên xuất sắc nhất 2021</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".timeline-cv { font-family: 'Verdana', sans-serif; color: #333; padding: 20px; background: #fff; } .timeline-cv header { text-align: center; padding-bottom: 20px; border-bottom: 2px solid #d2691e; } .timeline-cv h1 { font-size: 32px; color: #d2691e; } .timeline-cv h2 { font-size: 22px; color: #d2691e; margin: 20px 0 10px; } .timeline-cv h3 { font-size: 18px; color: #333; } .timeline-cv .event { position: relative; margin: 20px 0; padding-left: 140px; } .timeline-cv .event span { position: absolute; left: 0; width: 120px; color: #ff8c00; font-weight: bold; font-size: 14px; } .timeline-cv .event:before { content: ''; position: absolute; left: 130px; top: 0; bottom: 0; width: 2px; background: #ff8c00; } .timeline-cv .event:after { content: '●'; position: absolute; left: 126px; top: 5px; color: #ff8c00; font-size: 16px; }", "<div class=\"timeline-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>📞 {PhoneNumber} | ✉ {Email}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Phát triển sự nghiệp qua các cột mốc quan trọng, mang lại giá trị bền vững cho công ty.</p></section><section><h2>Hành trình nghề nghiệp</h2><div class=\"event\"><span>08/2020 - 08/2022</span><h3>Tổng đài viên - Công ty ABC</h3><p>Tư vấn 100+ khách hàng/ngày, đạt 150% KPI</p></div><div class=\"event\"><span>08/2018 - 07/2020</span><h3>Chuyên viên tư vấn - Công ty BCD</h3><p>Tìm kiếm và ký hợp đồng với 50+ khách hàng/ngày</p></div></section><section><h2>Học vấn</h2><div class=\"event\"><span>2016 - 2020</span><h3>Đại học XYZ</h3><p>Cử nhân Quản trị Kinh doanh</p></div></section><section><h2>Chứng chỉ</h2><p>Kỹ năng bán hàng - 2021</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".modern-cv { font-family: 'Arial', sans-serif; display: flex; color: #4b0082; background: #fff; } .modern-cv aside { width: 30%; background: #e6e6fa; padding: 20px; border-right: 3px solid #4b0082; } .modern-cv main { width: 70%; padding: 20px; } .modern-cv h1 { font-size: 30px; color: #4b0082; } .modern-cv .contact { font-size: 14px; line-height: 1.8; } .modern-cv h2 { font-size: 22px; color: #483d8b; margin: 20px 0 10px; border-bottom: 2px solid #483d8b; padding-bottom: 5px; } .modern-cv h3 { font-size: 18px; } .modern-cv ul { list-style-type: disc; margin-left: 20px; }", "<div class=\"modern-cv\"><aside><h1>{FullName}</h1><p>{JobTitle}</p><div class=\"contact\">📞 {PhoneNumber}<br>✉ {Email}<br>🏠 {Address}<br>🌐 {Website}</div></aside><main><section><h2>Mục tiêu nghề nghiệp</h2><p>Tận dụng kỹ năng hiện đại để nâng cao hiệu suất tư vấn và doanh thu công ty.</p></section><section><h2>Kỹ năng</h2><ul><li>Tư vấn chuyên sâu</li><li>Phân tích dữ liệu</li><li>Giao tiếp đa kênh</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Chuyên viên tư vấn - Công ty ABC</h3><p>08/2020 - 08/2022</p><ul><li>Tăng 200% doanh thu qua chiến lược mới</li><li>Đạt danh hiệu Nhân viên xuất sắc</li></ul></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Công nghệ Thông tin</p></div></section><section><h2>Người giới thiệu</h2><p>Ông A - CEO Công ty ABC - abc@gmail.com</p></section></main></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".minimalist-cv { font-family: 'Georgia', serif; color: #666; padding: 20px; background: #fff; } .minimalist-cv header { border-bottom: 1px solid #999; padding-bottom: 15px; margin-bottom: 20px; } .minimalist-cv h1 { font-size: 32px; color: #333; } .minimalist-cv h2 { font-size: 20px; color: #333; margin: 20px 0 10px; } .minimalist-cv h3 { font-size: 18px; } .minimalist-cv ul { list-style-type: none; margin-left: 0; } .minimalist-cv ul li:before { content: '—'; margin-right: 5px; color: #999; }", "<div class=\"minimalist-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>📞 {PhoneNumber} | ✉ {Email}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Tập trung vào hiệu quả tư vấn, mang lại giá trị thiết thực.</p></section><section><h2>Kỹ năng</h2><ul><li>Tư vấn</li><li>Thuyết phục</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Nhân viên tư vấn - Công ty ABC</h3><p>08/2020 - 08/2022</p><p>Tư vấn 100+ khách hàng/ngày</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Kinh tế</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".classic-cv { font-family: 'Garamond', serif; color: #8b4513; padding: 25px; background: #fdf5e6; } .classic-cv header { text-align: center; margin-bottom: 25px; border-bottom: 2px solid #8b4513; } .classic-cv h1 { font-size: 34px; color: #8b4513; } .classic-cv h2 { font-size: 24px; margin: 20px 0 10px; color: #8b4513; } .classic-cv h3 { font-size: 18px; } .classic-cv ul { list-style-type: disc; margin-left: 20px; }", "<div class=\"classic-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>📞 {PhoneNumber} | ✉ {Email} | 🏠 {Address}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Phát triển sự nghiệp lâu dài trong lĩnh vực tư vấn khách hàng.</p></section><section><h2>Kỹ năng</h2><ul><li>Giao tiếp</li><li>Đàm phán</li><li>Chăm sóc khách hàng</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Tổng đài viên - Công ty ABC</h3><p>08/2020 - 08/2022</p><ul><li>Tư vấn 100+ khách hàng/ngày</li><li>Đạt 150% KPI</li></ul></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Quản trị Kinh doanh</p></div></section><section><h2>Chứng chỉ</h2><p>Chứng chỉ Kỹ năng Tư vấn - 2021</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".corporate-cv { font-family: 'Calibri', sans-serif; color: #000080; padding: 20px; background: #f0f0f0; border-radius: 5px; } .corporate-cv header { background: #e0e0e0; padding: 20px; margin-bottom: 20px; border-bottom: 3px solid #000080; } .corporate-cv h1 { font-size: 32px; color: #000080; } .corporate-cv h2 { font-size: 22px; color: #191970; margin: 20px 0 10px; padding: 5px; background: #d3d3d3; } .corporate-cv h3 { font-size: 18px; } .corporate-cv ul { list-style-type: square; margin-left: 20px; }", "<div class=\"corporate-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>📞 {PhoneNumber} | ✉ {Email} | 🌐 {Website}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Góp phần xây dựng chiến lược tư vấn chuyên nghiệp, tăng trưởng doanh thu công ty.</p></section><section><h2>Kỹ năng</h2><ul><li>Quản lý khách hàng</li><li>Tư vấn doanh nghiệp</li><li>Lập kế hoạch</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Chuyên viên tư vấn - Công ty ABC</h3><p>08/2020 - 08/2022</p><ul><li>Hỗ trợ 50+ khách hàng/ngày</li><li>Tăng 200% doanh thu</li></ul></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Kinh tế</p></div></section><section><h2>Danh hiệu</h2><p>Nhân viên xuất sắc Quý 3/2021</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".academic-cv { font-family: 'Bookman Old Style', serif; color: #800000; padding: 20px; background: #fffaf0; } .academic-cv header { margin-bottom: 20px; border-bottom: 2px solid #800000; padding-bottom: 15px; } .academic-cv h1 { font-size: 32px; color: #800000; } .academic-cv h2 { font-size: 22px; color: #8b0000; margin: 20px 0 10px; border-bottom: 1px solid #8b0000; } .academic-cv h3 { font-size: 18px; }", "<div class=\"academic-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>📞 {PhoneNumber} | ✉ {Email} | 🏠 {Address}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Ứng dụng kiến thức học thuật vào thực tiễn tư vấn và nghiên cứu.</p></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Kinh tế - GPA: 3.9/4.0</p></div></section><section><h2>Ấn phẩm/Nghiên cứu</h2><p>Nghiên cứu: Tăng hiệu quả tư vấn qua dữ liệu - 2021</p></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Trợ giảng - Đại học XYZ</h3><p>08/2020 - 08/2022</p><p>Hỗ trợ giảng dạy và tư vấn sinh viên</p></div></section><section><h2>Chứng chỉ</h2><p>Chứng chỉ Nghiên cứu Khoa học - 2020</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".technical-cv { font-family: 'Courier New', monospace; display: flex; color: #008080; background: #f5fafa; } .technical-cv aside { width: 25%; background: #e0ffff; padding: 20px; border-right: 3px solid #008080; } .technical-cv main { width: 75%; padding: 20px; } .technical-cv h1 { font-size: 30px; color: #008080; } .technical-cv .contact { font-size: 14px; line-height: 1.8; } .technical-cv h2 { font-size: 22px; color: #006d5b; margin: 20px 0 10px; background: #e0ffff; padding: 5px; } .technical-cv h3 { font-size: 18px; } .technical-cv ul { list-style-type: circle; margin-left: 20px; }", "<div class=\"technical-cv\"><aside><h1>{FullName}</h1><p>{JobTitle}</p><div class=\"contact\">📞 {PhoneNumber}<br>✉ {Email}<br>🌐 {Website}</div></aside><main><section><h2>Mục tiêu nghề nghiệp</h2><p>Tận dụng kỹ năng kỹ thuật để tối ưu hóa quy trình tư vấn và hỗ trợ khách hàng.</p></section><section><h2>Kỹ năng kỹ thuật</h2><ul><li>Phân tích dữ liệu</li><li>Lập trình Python</li><li>Quản lý CRM</li></ul></section><section><h2>Dự án</h2><div class=\"job\"><h3>Dự án CRM - Công ty ABC</h3><p>08/2020 - 08/2022</p><ul><li>Tối ưu hệ thống CRM, tăng hiệu suất 30%</li><li>Hỗ trợ 50+ khách hàng/ngày</li></ul></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Đại học XYZ</h3><p>2016 - 2020</p><p>Cử nhân Công nghệ Thông tin</p></div></section><section><h2>Người giới thiệu</h2><p>Ông B - CTO Công ty ABC - abc@gmail.com</p></section></main></div>" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".simple-cv { font-family: Arial, sans-serif; color: #333; padding: 20px; } .simple-cv header { text-align: center; margin-bottom: 20px; } .simple-cv h1 { font-size: 28px; color: #000; } .simple-cv h2 { font-size: 20px; color: #555; border-bottom: 1px solid #ccc; margin-top: 20px; } .simple-cv h3 { font-size: 18px; margin: 10px 0 5px; } .simple-cv ul { list-style-type: disc; margin-left: 20px; } .simple-cv .job, .simple-cv .edu { margin-bottom: 15px; }", "<div class=\"simple-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>Ngày sinh: {BirthDate} | Giới tính: {Gender}</p><p>Số điện thoại: {PhoneNumber} | Email: {Email} | Địa chỉ: {Address}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp của bạn tại đây...</p></section><section><h2>Kỹ năng</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Công ty mẫu</h3><p>Thời gian: MM/YYYY - MM/YYYY</p><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>Thời gian: YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".professional-cv { font-family: 'Times New Roman', serif; color: #1e3a8a; padding: 25px; } .professional-cv header { border-bottom: 2px solid #1e3a8a; padding-bottom: 10px; margin-bottom: 20px; } .professional-cv h1 { font-size: 30px; } .professional-cv h2 { font-size: 22px; color: #1e3a8a; margin-top: 20px; } .professional-cv h3 { font-size: 18px; } .professional-cv ul { list-style-type: square; margin-left: 20px; }", "<div class=\"professional-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>Số điện thoại: {PhoneNumber} | Email: {Email} | Địa chỉ: {Address}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kỹ năng</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Công ty mẫu</h3><p>MM/YYYY - MM/YYYY</p><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".creative-cv { font-family: 'Helvetica', sans-serif; color: #2f4f4f; background: #f0f8ff; padding: 20px; border-radius: 10px; } .creative-cv header { background: #ff4500; color: #fff; padding: 15px; border-radius: 5px; } .creative-cv h1 { font-size: 32px; } .creative-cv h2 { font-size: 20px; color: #4682b4; margin-top: 20px; } .creative-cv h3 { font-size: 18px; } .creative-cv ul { list-style-type: circle; margin-left: 20px; }", "<div class=\"creative-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>{Email} | {PhoneNumber} | {Address} | {Website}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kỹ năng</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Công ty mẫu</h3><p>MM/YYYY - MM/YYYY</p><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".timeline-cv { font-family: 'Verdana', sans-serif; color: #333; padding: 20px; } .timeline-cv header { text-align: center; } .timeline-cv h1 { font-size: 28px; color: #d2691e; } .timeline-cv h2 { font-size: 20px; margin-top: 20px; } .timeline-cv h3 { font-size: 18px; } .timeline-cv .event { margin: 15px 0; } .timeline-cv .event span { display: inline-block; width: 120px; color: #ff8c00; font-weight: bold; }", "<div class=\"timeline-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>Số điện thoại: {PhoneNumber} | Email: {Email}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"event\"><span>MM/YYYY - MM/YYYY</span><h3>Công ty mẫu</h3><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"event\"><span>YYYY - YYYY</span><h3>Trường mẫu</h3><p>Nhập thông tin học vấn tại đây...</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".modern-cv { font-family: 'Arial', sans-serif; display: flex; color: #4b0082; } .modern-cv aside { width: 30%; background: #e6e6fa; padding: 20px; } .modern-cv main { width: 70%; padding: 20px; } .modern-cv h1 { font-size: 26px; } .modern-cv h2 { font-size: 20px; color: #483d8b; margin-top: 20px; } .modern-cv h3 { font-size: 18px; } .modern-cv ul { list-style-type: disc; margin-left: 20px; }", "<div class=\"modern-cv\"><aside><h1>{FullName}</h1><p>{JobTitle}</p><p>{Email}<br>{PhoneNumber}<br>{Address}<br>{Website}</p></aside><main><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kỹ năng</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Công ty mẫu</h3><p>MM/YYYY - MM/YYYY</p><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></main></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".minimalist-cv { font-family: 'Georgia', serif; color: #666; padding: 20px; } .minimalist-cv header { border-bottom: 1px solid #999; padding-bottom: 10px; } .minimalist-cv h1 { font-size: 30px; color: #333; } .minimalist-cv h2 { font-size: 18px; margin-top: 20px; } .minimalist-cv h3 { font-size: 16px; }", "<div class=\"minimalist-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>{PhoneNumber} | {Email}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Công ty mẫu</h3><p>MM/YYYY - MM/YYYY</p><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".classic-cv { font-family: 'Garamond', serif; color: #8b4513; padding: 25px; } .classic-cv header { text-align: center; margin-bottom: 20px; } .classic-cv h1 { font-size: 32px; } .classic-cv h2 { font-size: 22px; margin-top: 20px; } .classic-cv h3 { font-size: 18px; } .classic-cv ul { list-style-type: disc; margin-left: 20px; }", "<div class=\"classic-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>{PhoneNumber} | {Email} | {Address}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kỹ năng</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Công ty mẫu</h3><p>MM/YYYY - MM/YYYY</p><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".corporate-cv { font-family: 'Calibri', sans-serif; color: #000080; padding: 20px; } .corporate-cv header { background: #f0f0f0; padding: 15px; margin-bottom: 20px; } .corporate-cv h1 { font-size: 28px; } .corporate-cv h2 { font-size: 20px; color: #191970; margin-top: 20px; } .corporate-cv h3 { font-size: 18px; }", "<div class=\"corporate-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>{PhoneNumber} | {Email} | {Website}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kinh nghiệm làm việc</h2><div class=\"job\"><h3>Công ty mẫu</h3><p>MM/YYYY - MM/YYYY</p><p>Nhập mô tả công việc tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".academic-cv { font-family: 'Bookman Old Style', serif; color: #800000; padding: 20px; } .academic-cv header { margin-bottom: 20px; } .academic-cv h1 { font-size: 30px; } .academic-cv h2 { font-size: 20px; color: #8b0000; margin-top: 20px; } .academic-cv h3 { font-size: 18px; }", "<div class=\"academic-cv\"><header><h1>{FullName}</h1><p>{JobTitle}</p><p>{PhoneNumber} | {Email} | {Address}</p></header><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section><section><h2>Ấn phẩm/Nghiên cứu</h2><p>Nhập thông tin ấn phẩm hoặc nghiên cứu tại đây...</p></section></div>" });

            migrationBuilder.UpdateData(
                table: "CVTemplates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CssTemplate", "HtmlTemplate" },
                values: new object[] { ".technical-cv { font-family: 'Courier New', monospace; display: flex; color: #008080; } .technical-cv aside { width: 25%; background: #e0ffff; padding: 15px; } .technical-cv main { width: 75%; padding: 15px; } .technical-cv h1 { font-size: 26px; } .technical-cv h2 { font-size: 20px; color: #006d5b; margin-top: 20px; } .technical-cv h3 { font-size: 18px; } .technical-cv ul { list-style-type: circle; margin-left: 20px; }", "<div class=\"technical-cv\"><aside><h1>{FullName}</h1><p>{JobTitle}</p><p>{Email}<br>{PhoneNumber}<br>{Website}</p></aside><main><section><h2>Mục tiêu nghề nghiệp</h2><p>Nhập mục tiêu nghề nghiệp tại đây...</p></section><section><h2>Kỹ năng kỹ thuật</h2><ul><li>Kỹ năng 1</li><li>Kỹ năng 2</li></ul></section><section><h2>Dự án</h2><div class=\"job\"><h3>Dự án mẫu</h3><p>MM/YYYY - MM/YYYY</p><p>Nhập mô tả dự án tại đây...</p></div></section><section><h2>Học vấn</h2><div class=\"edu\"><h3>Trường mẫu</h3><p>YYYY - YYYY</p><p>Nhập thông tin học vấn tại đây...</p></div></section></main></div>" });
        }
    }
}
