using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _2121_wave_cafe.Data;
using _2121_wave_cafe.Models;

namespace cafe1.Controllers
{
    public class cafeController : Controller
    {
        private readonly _2121_wave_cafeContext _context;

        public cafeController(_2121_wave_cafeContext context)
        {
            _context = context;
        }

        // GET: cafe
        public async Task<IActionResult> Index(string cafeSốLượng, string searchString)
        {
            // Use LINQ to get list of SốLượng.
            IQueryable<string> SốLượngQuery = from b in _context.cafe
                                            orderby b.SốLượng
                                            select b.SốLượng;
            var cafes = from b in _context.cafe
                        select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                cafes = cafes.Where(s => s.TênSP!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(cafeSốLượng))
            {
                cafes = cafes.Where(x => x.SốLượng == cafeSốLượng);
            }
            var cafesoluongVM = new cafesoluong
            {
                SốLượng = new SelectList(await
           SốLượngQuery.Distinct().ToListAsync()),
                cafes = await cafes.ToListAsync()
            };
            return View(cafesoluongVM);
        }

        // GET: cafe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cafe = await _context.cafe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cafe == null)
            {
                return NotFound();
            }

            return View(cafe);
        }

        // GET: cafe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: cafe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TênSP,NgàyNhập,SốLượng,GiáTiền,NhậnXét")] cafe cafe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cafe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cafe);
        }

        // GET: cafe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cafe = await _context.cafe.FindAsync(id);
            if (cafe == null)
            {
                return NotFound();
            }
            return View(cafe);
        }

        // POST: cafe1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TênSP,NgàyNhập,SốLượng,GiáTiền,NhậnXét")] cafe cafe)
        {
            if (id != cafe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cafe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cafe1Exists (cafe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cafe);
        }

        // GET: cafe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cafe = await _context.cafe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cafe == null)
            {
                return NotFound();
            }

            return View(cafe);
        }

        // POST: cafe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cafe1 = await _context.cafe.FindAsync(id);
            _context.cafe.Remove(cafe1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool cafe1Exists(int id)
        {
            return _context.cafe.Any(e => e.Id == id);
        }
    }
}
