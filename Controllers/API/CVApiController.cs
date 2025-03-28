using CVOnline.Web.Data;
using CVOnline.Web.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CVOnline.Web.Controllers.API
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CVApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CVApiController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet("templates")]
        public async Task<IActionResult> GetTemplates()
        {
            var templates = await _context.CVTemplates.ToListAsync();
            return Ok(templates);
        }

        [HttpGet("template/{id}")]
        public async Task<IActionResult> GetTemplate(int id)
        {
            var template = await _context.CVTemplates.FindAsync(id);
            if (template == null)
            {
                return NotFound();
            }

            return Ok(template);
        }

        [HttpGet("user-cvs")]
        public async Task<IActionResult> GetUserCVs()
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    Console.WriteLine("Không tìm thấy người dùng hiện tại.");
                    return Unauthorized(new { message = "Không tìm thấy người dùng hiện tại." });
                }

                Console.WriteLine($"Đang lấy CV cho người dùng: {user.Id}");

                var cvs = await _context.CVs
                    .Include(c => c.Template)
                    .Where(c => c.UserId == user.Id)
                    .ToListAsync();

                Console.WriteLine($"Số lượng CV tìm thấy: {cvs.Count}");

                return Ok(cvs);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách CV: {ex.Message}");
                return StatusCode(500, new { message = "Đã có lỗi xảy ra khi lấy danh sách CV.", error = ex.Message });
            }
        }
    }
}