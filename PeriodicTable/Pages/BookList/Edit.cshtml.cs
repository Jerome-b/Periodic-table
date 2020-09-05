//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using PeriodicTable.Model;

//namespace PeriodicTable
//{
//    public class EditModel : PageModel
//    {
//        private ApplicationDbContext _db;

//        public EditModel(ApplicationDbContext db)
//        {
//            _db = db;
//        }

//        [BindProperty]

//        public Book Book { get; set; }
//        public async Task OnGet(int id)
//        {
//            Book = await _db.Book.FindAsync(id).ConfigureAwait(true);
//        }

//        public async Task<IActionResult> OnPost()
//        {
//            if (ModelState.IsValid)
//            {
//                var BookFromDb = await _db.Book.FindAsync(Book.Id).ConfigureAwait(true);
//                BookFromDb.Name = Book.Name;
//                BookFromDb.Author = Book.Author;
//                BookFromDb.ISBN = Book.ISBN;

//                await _db.SaveChangesAsync().ConfigureAwait(true);

//                return RedirectToPage("Index");
//            }

//            return RedirectToPage();
//        }
//    }
//}