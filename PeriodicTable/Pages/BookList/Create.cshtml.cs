//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using PeriodicTable.Model;

//namespace PeriodicTable
//{
//    public class CreateModel : PageModel
//    {
//        private readonly ApplicationDbContext _db;

//        public CreateModel(ApplicationDbContext db)
//        {
//            _db = db;
//        }

//        [BindProperty]

//        public Book Book { get; set; }
//        public void OnGet()
//        {

//        }

//        public async Task<IActionResult> OnPost()
//        {
//            if (ModelState.IsValid)
//            {
//                await _db.Book.AddAsync(Book).ConfigureAwait(true);
//                await _db.SaveChangesAsync().ConfigureAwait(true);
//                return RedirectToPage("Index");
//            } else
//            {
//                return Page();
//            }
//        }
//    }
//}