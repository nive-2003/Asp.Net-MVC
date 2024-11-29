using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleShopRazor.Datas;
using VehicleShopRazor.NewFolder;

namespace VehicleShopRazor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0) {
                Category = _db.Category.Find(id);
            }
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                _db.Category.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category edited successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }

    }
}
