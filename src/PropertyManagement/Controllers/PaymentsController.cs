using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PropertyManagement.Models;

namespace PropertyManagement.Controllers
{
    public class PaymentsController : Controller
    {
        private PropertyManagementDbContext _context;

        public PaymentsController(PropertyManagementDbContext context)
        {
            _context = context;    
        }

        // GET: Payments
        public IActionResult Index()
        {
            return View(_context.Payment.ToList());
        }

        // GET: Payments/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Payment payment = _context.Payment.Single(m => m.PaymentId == id);
            if (payment == null)
            {
                return HttpNotFound();
            }

            return View(payment);
        }

        // GET: Payments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Payments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Payment payment)
        {
            if (ModelState.IsValid)
            {
                _context.Payment.Add(payment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payment);
        }

        // GET: Payments/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Payment payment = _context.Payment.Single(m => m.PaymentId == id);
            if (payment == null)
            {
                return HttpNotFound();
            }
            return View(payment);
        }

        // POST: Payments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Payment payment)
        {
            if (ModelState.IsValid)
            {
                _context.Update(payment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payment);
        }

        // GET: Payments/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Payment payment = _context.Payment.Single(m => m.PaymentId == id);
            if (payment == null)
            {
                return HttpNotFound();
            }

            return View(payment);
        }

        // POST: Payments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Payment payment = _context.Payment.Single(m => m.PaymentId == id);
            _context.Payment.Remove(payment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
