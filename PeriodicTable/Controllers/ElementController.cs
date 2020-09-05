using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodicTable.Model;

namespace PeriodicTable.Controllers
{

    [Route("api/Element")]
    [ApiController]
    public class ElementController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ElementController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Element.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var elementFromDb = await _db.Element.FirstOrDefaultAsync(u => u.AtomicNumber == id);
            if (elementFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Element.Remove(elementFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
    }
}