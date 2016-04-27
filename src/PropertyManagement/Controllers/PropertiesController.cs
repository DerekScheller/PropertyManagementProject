using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PropertyManagement.Models;
using System.Collections.Generic;

namespace PropertyManagement.Controllers
{
    public class PropertiesController : Controller
    {
        private PropertyManagementDbContext _context;

        public PropertiesController(PropertyManagementDbContext context)
        {
            _context = context;    
        }

        // GET: Properties1
        public IActionResult Index()
        {
            var properties = _context.Property.ToList();
            List<Property> AvailableProperties = new List<Property>();
            foreach (Property item in properties)
            {
                if (item.IsOccupied == false)
                {
                    AvailableProperties.Add(item);
                }

            }
            return View(AvailableProperties);
        }

        // GET: Properties1/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Property property = _context.Property.Single(m => m.PropertyId == id);
            if (property == null)
            {
                return HttpNotFound();
            }

            return View(property);
        }

        // GET: Properties1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Properties1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Property property)
        {
            if (ModelState.IsValid)
            {
                _context.Property.Add(property);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(property);
        }

        // GET: Properties1/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Property property = _context.Property.Single(m => m.PropertyId == id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        // POST: Properties1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Property property)
        {
            if (ModelState.IsValid)
            {
                _context.Update(property);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(property);
        }

        // GET: Properties1/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Property property = _context.Property.Single(m => m.PropertyId == id);
            if (property == null)
            {
                return HttpNotFound();
            }

            return View(property);
        }

        // POST: Properties1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Property property = _context.Property.Single(m => m.PropertyId == id);
            _context.Property.Remove(property);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
