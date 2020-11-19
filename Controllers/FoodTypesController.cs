using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApiMeatTemp.Models;

namespace ApiMeatTemp.Controllers
{
    public class FoodTypesController : Controller
    {
        private FoodContext db = new FoodContext();

        // GET: FoodTypes
        [Authorize]
        public async Task<ActionResult> Index()
        {
            return View(await db.FoodTypes.ToListAsync());
        }

        // GET: FoodTypes/Details/5
        [Authorize]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodType foodType = await db.FoodTypes.FindAsync(id);
            if (foodType == null)
            {
                return HttpNotFound();
            }
            return View(foodType);
        }

        // GET: FoodTypes/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FoodName")] FoodType foodType)
        {
            if (ModelState.IsValid)
            {
                db.FoodTypes.Add(foodType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(foodType);
        }

        // GET: FoodTypes/Edit/5
        [Authorize]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodType foodType = await db.FoodTypes.FindAsync(id);
            if (foodType == null)
            {
                return HttpNotFound();
            }
            return View(foodType);
        }

        // POST: FoodTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FoodName")] FoodType foodType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(foodType);
        }

        // GET: FoodTypes/Delete/5
        [Authorize]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodType foodType = await db.FoodTypes.FindAsync(id);
            if (foodType == null)
            {
                return HttpNotFound();
            }
            return View(foodType);
        }

        // POST: FoodTypes/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FoodType foodType = await db.FoodTypes.FindAsync(id);
            db.FoodTypes.Remove(foodType);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
