using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TraineePro.Data;
using TraineePro.Models;

namespace TraineePro.Controllers
{
    public class TestModelsController : Controller
    {
        private readonly ApplicationDbcontext _context;
        private int id;

        public TestModelsController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: TestModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestModel.ToListAsync());
        }

        // GET: TestModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testModel = await _context.TestModel
                .FirstOrDefaultAsync(m => m.TraineeID == id);
            if (testModel == null)
            {
                return NotFound();
            }

            return View(testModel);
        }

        // GET: TestModels/Create
        public IActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TraineeID,FirstName,MiddleName,ThirdName,LastName,NationalID,UniversityID,Email,Phone,BirthDate,Gender,University,collage,Major,TrainingStartDate,TrainingEndDate")] TestModel testModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("SubmissionConfirmation","Home");
            }
            return View(testModel);
        }

        // GET: TestModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testModel = await _context.TestModel.FindAsync(id);
            if (testModel == null)
            {
                return NotFound();
            }
            return View(testModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TestModel testModel)
        {
            if (id != testModel.TraineeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestModelExists(testModel.TraineeID))
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
            return View(testModel);
        }

        // GET: TestModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testModel = await _context.TestModel
                .FirstOrDefaultAsync(m => m.TraineeID == id);
            if (testModel == null)
            {
                return NotFound();
            }

            return View(testModel);
        }

        // POST: TestModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testModel = await _context.TestModel.FindAsync(id);
            if (testModel != null)
            {
                _context.TestModel.Remove(testModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestModelExists(int id)
        {
            return _context.TestModel.Any(e => e.TraineeID == id);
        }
    }
}
