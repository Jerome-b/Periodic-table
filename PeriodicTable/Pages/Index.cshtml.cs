using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PeriodicTable.Model;

namespace PeriodicTable.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IList<Element> Elements { get; set; }

        public async Task OnGet()
        {
            Elements = await _db.Element.ToListAsync();
        }
    }
}

//    public class IndexModel : PageModel
//    {

//        private readonly ApplicationDbContext _db;

//        public IndexModel(ApplicationDbContext db)
//        {
//           _db = db;
//        }

//        public IEnumerable<Book> Books { get; set; }

//        public async Task OnGet()
//        {
//            Books = await _db.Book.ToListAsync();
//        }

//        public async Task<IActionResult> OnPostDelete(int id)
//        {
//            var book = await _db.Book.FindAsync(id);
//            if (book == null)
//            {
//                return NotFound();
//            }
//            _db.Book.Remove(book);
//            await _db.SaveChangesAsync();

//            return RedirectToPage("Index");
//        }
//    }
