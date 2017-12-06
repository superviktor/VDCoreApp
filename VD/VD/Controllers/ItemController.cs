using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VD.Models.BasicItm;

namespace VD.Controllers
{
    public class ItemController : Controller
    {
        private Models.AppContext _context;
        public ItemController(Models.AppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Items.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}