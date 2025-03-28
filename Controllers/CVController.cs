using CVOnline.Web.Data;
using CVOnline.Web.Models.Domain;
using CVOnline.Web.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace CVOnline.Web.Controllers
{
    [Authorize]
    public class CVController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CVController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        // [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var cvs = await _context.CVs
                .Include(c => c.Template)
                .Where(c => c.UserId == user.Id)
                .ToListAsync();
            List<CV> ds = await _context.CVs
                .Include(c => c.Template)
                .Where(c => c.UserId == user.Id)
                .ToListAsync();
            ViewBag.sl = cvs.Count();
            ViewBag.ds = ds;
            return View(cvs);
        }

        public async Task<IActionResult> Templates()
        {
            var templates = await _context.CVTemplates.ToListAsync();
            return View(templates);
        }

        public async Task<IActionResult> Create(int templateId)
        {
            var template = await _context.CVTemplates.FindAsync(templateId);
            if (template == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);

            var viewModel = new CreateCVViewModel
            {
                TemplateId = templateId,
                TemplateName = template.Name,
                PreviewImageUrl = template.PreviewImageUrl,
                FullName = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCVViewModel model)
        {
            Console.WriteLine("Create CV action called");

            if (model == null)
            {
                Console.WriteLine("Model is null.");
                return BadRequest(new { success = false, message = "Dữ liệu không hợp lệ!" });
            }

            if (!ModelState.IsValid)
            {
                var errors = ModelState.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );

                Console.WriteLine("ModelState is not valid.");
                return BadRequest(new { success = false, message = "Dữ liệu không hợp lệ!", errors });
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return BadRequest(new { success = false, message = "Bạn cần đăng nhập để lưu CV!" });
            }

            var cv = new CV
            {
                Title = model.Title,
                Content = model.Content,
                TemplateId = model.TemplateId,
                UserId = user.Id,
                CreatedDate = DateTime.UtcNow
            };

            try
            {
                _context.CVs.Add(cv);
                await _context.SaveChangesAsync();
                Console.WriteLine("CV saved successfully.");
                return Ok(new { success = true, message = "CV đã được lưu thành công!" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving CV: {ex.Message}");
                return StatusCode(500, new { success = false, message = "Lỗi khi lưu CV! Hãy thử lại." });
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var cv = await _context.CVs
                .Include(c => c.Template)
                .FirstOrDefaultAsync(c => c.Id == id && c.UserId == user.Id);

            if (cv == null)
            {
                return NotFound();
            }

            var viewModel = new EditCVViewModel
            {
                Id = cv.Id,
                Title = cv.Title,
                Content = cv.Content,
                TemplateId = cv.TemplateId,
                TemplateName = cv.Template.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCVViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var cv = await _context.CVs
                    .FirstOrDefaultAsync(c => c.Id == model.Id && c.UserId == user.Id);

                if (cv == null)
                {
                    return NotFound();
                }

                cv.Title = model.Title;
                cv.Content = model.Content;
                cv.UpdatedDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized(new { message = "Bạn cần đăng nhập để xóa CV!" });
            }

            var cv = await _context.CVs
                .Include(c => c.Template) // Include Template để hiển thị thông tin trong view
                .FirstOrDefaultAsync(c => c.Id == id && c.UserId == user.Id);

            if (cv == null)
            {
                return NotFound();
            }

            return View(cv);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized(new { message = "Bạn cần đăng nhập để xóa CV!" });
            }

            var cv = await _context.CVs
                .FirstOrDefaultAsync(c => c.Id == id && c.UserId == user.Id);

            if (cv == null)
            {
                return NotFound();
            }

            _context.CVs.Remove(cv);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "CV đã được xóa thành công!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Preview(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var cv = await _context.CVs
                .Include(c => c.Template)
                .FirstOrDefaultAsync(c => c.Id == id && c.UserId == user.Id);

            if (cv == null)
            {
                return NotFound();
            }

            return View(cv);
        }
    }
}