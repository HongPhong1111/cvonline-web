using System.Security.Claims;
using CVOnline.Web.Data;
using CVOnline.Web.Models.Domain;
using CVOnline.Web.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> Templates(string searchString)
        {
            var templates = _context.CVTemplates.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                templates = templates.Where(t => t.Name.ToLower().Contains(searchString) || 
                                                t.Category.ToLower().Contains(searchString));
            }

            var result = await templates.ToListAsync();
            ViewBag.SearchString = searchString;
            return View(result);
        }

        [HttpGet]
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
                HtmlTemplate = template.HtmlTemplate ?? "",
                CssTemplate = template.CssTemplate ?? "",  
                FullName = user.FullName ?? "Nguyễn Văn A",
                JobTitle = "Nhân viên tư vấn",
                BirthDate = "15/05/1990",
                Gender = "Nam",
                PhoneNumber = user.PhoneNumber ?? "0123-456-789",
                Email = user.Email ?? "tencuaban@example.com",
                Address = user.Address ?? "Quận X, Thành phố Y",
                Website = "be.net/tencuaban"
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCVViewModel model)
        {
            ModelState.Remove("Photo");
            ModelState.Remove("PhotoUrl");
            ModelState.Remove("HtmlTemplate");
            ModelState.Remove("CssTemplate");
            ModelState.Remove("JobTitle");
            ModelState.Remove("BirthDate");
            ModelState.Remove("Gender");
            ModelState.Remove("TemplateName");
            ModelState.Remove("PreviewImageUrl");
            ModelState.Remove("FullName");
            ModelState.Remove("Email");
            ModelState.Remove("PhoneNumber");
            ModelState.Remove("Address");
            ModelState.Remove("Website");

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return Json(new { success = false, message = "Dữ liệu không hợp lệ: " + string.Join(", ", errors) });
            }

            string photoUrl = null;
            if (model.Photo != null && model.Photo.Length > 0)
            {
                var imagesFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                try
                {
                    if (!Directory.Exists(imagesFolder))
                    {
                        Directory.CreateDirectory(imagesFolder);
                    }

                    var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.Photo.FileName);
                    var filePath = Path.Combine(imagesFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Photo.CopyToAsync(fileStream);
                    }
                    photoUrl = "/images/" + uniqueFileName;
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, message = "Lỗi khi lưu ảnh: " + ex.Message });
                }
            }

            var cv = new CV
            {
                Title = model.Title,
                Content = model.Content,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                TemplateId = model.TemplateId,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                PhotoUrl = photoUrl
            };

            _context.CVs.Add(cv);
            await _context.SaveChangesAsync();

            var template = await _context.CVTemplates.FindAsync(model.TemplateId);
            if (template != null)
            {
                template.UsageCount++;
                await _context.SaveChangesAsync();
            }

            return Json(new { success = true, message = "CV đã được lưu thành công!" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cv = await _context.CVs.Include(c => c.Template).FirstOrDefaultAsync(c => c.Id == id);
            if (cv == null || cv.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return NotFound();
            }

            var model = new EditCVViewModel
            {
                Id = cv.Id,
                TemplateId = cv.TemplateId,
                TemplateName = cv.Template.Name,
                Title = cv.Title,
                Content = cv.Content,
                PhotoUrl = cv.PhotoUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCVViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var cv = await _context.CVs.FindAsync(model.Id);
            if (cv == null || cv.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return NotFound();
            }

            string photoUrl = cv.PhotoUrl;
            if (model.Photo != null && model.Photo.Length > 0)
            {
                var imagesFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                try
                {
                    if (!Directory.Exists(imagesFolder))
                    {
                        Directory.CreateDirectory(imagesFolder);
                    }

                    var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.Photo.FileName);
                    var filePath = Path.Combine(imagesFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Photo.CopyToAsync(fileStream);
                    }
                    photoUrl = "/images/" + uniqueFileName;

                    if (!string.IsNullOrEmpty(cv.PhotoUrl))
                    {
                        var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", cv.PhotoUrl.TrimStart('/'));
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = "Lỗi khi lưu ảnh: " + ex.Message;
                    return View(model);
                }
            }

            cv.Title = model.Title;
            cv.Content = model.Content;
            cv.PhotoUrl = photoUrl;
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "CV đã được cập nhật thành công!";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized(new { message = "Bạn cần đăng nhập để xóa CV!" });
            }

            var cv = await _context.CVs
                .Include(c => c.Template)
                .FirstOrDefaultAsync(c => c.Id == id && c.UserId == user.Id);

            if (cv == null)
            {
                return NotFound();
            }

            return View(cv);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var cv = await _context.CVs
                .Include(c => c.Template)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cv == null || cv.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                TempData["ErrorMessage"] = "Không tìm thấy CV hoặc bạn không có quyền xóa!";
                return RedirectToAction("Index");
            }

            try
            {
                var cvShares = await _context.CVShares
                    .Where(cs => cs.CVId == id)
                    .ToListAsync();
                if (cvShares.Any())
                {
                    _context.CVShares.RemoveRange(cvShares);
                }

                if (!string.IsNullOrEmpty(cv.PhotoUrl))
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", cv.PhotoUrl.TrimStart('/'));
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }

                _context.CVs.Remove(cv);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "CV đã được xóa thành công!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Lỗi khi xóa CV: " + ex.Message;
                if (ex.InnerException != null)
                {
                    TempData["InnerError"] = "Chi tiết lỗi: " + ex.InnerException.Message;
                }
            }

            return RedirectToAction("Index");
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