using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PropertyManagement.Models;

namespace PropertyManagement.Controllers
{
    public class HouseDocumentsController : Controller
    {
        private PropertyManagementDbContext _context;

        public HouseDocumentsController(PropertyManagementDbContext context)
        {
            _context = context;    
        }

        // GET: HouseDocuments
        public IActionResult Index()
        {
            return View(_context.HouseDocument.ToList());
        }

        // GET: HouseDocuments/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HouseDocument houseDocument = _context.HouseDocument.Single(m => m.HouseDocumentId == id);
            if (houseDocument == null)
            {
                return HttpNotFound();
            }

            return View(houseDocument);
        }

        // GET: HouseDocuments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HouseDocuments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HouseDocument houseDocument)
        {
            if (ModelState.IsValid)
            {
                _context.HouseDocument.Add(houseDocument);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(houseDocument);
        }

        // GET: HouseDocuments/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HouseDocument houseDocument = _context.HouseDocument.Single(m => m.HouseDocumentId == id);
            if (houseDocument == null)
            {
                return HttpNotFound();
            }
            return View(houseDocument);
        }

        // POST: HouseDocuments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HouseDocument houseDocument)
        {
            if (ModelState.IsValid)
            {
                _context.Update(houseDocument);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(houseDocument);
        }

        // GET: HouseDocuments/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HouseDocument houseDocument = _context.HouseDocument.Single(m => m.HouseDocumentId == id);
            if (houseDocument == null)
            {
                return HttpNotFound();
            }

            return View(houseDocument);
        }

        // POST: HouseDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            HouseDocument houseDocument = _context.HouseDocument.Single(m => m.HouseDocumentId == id);
            _context.HouseDocument.Remove(houseDocument);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
