using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL.Models;

namespace EntityFrameworkApproach.Controllers
{
    [Authorize(Roles = "admin")]
    public class InventoriesController : Controller
    {

        private CateringContext db = new CateringContext();

        // GET: Inventories
        public ActionResult Index()
        {
            var inventories = db.inventories.Include(i => i.cid).Include(i => i.product);
            return View(inventories.ToList());
        }

        // GET: Inventories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = db.inventories.Find(id);
            if (inventory == null)
            {
                return HttpNotFound();
            }
            return View(inventory);
        }

        public JsonResult FilterProducts(int id)
        {
            /*
            List<Product> plist = db.products.Where(e => e.categID == id).ToList();
            string products = string.Empty;
            foreach (Product p in plist)
            {
                products += p.name + ",";
            }
            products = products.TrimEnd(',');

            return Json(products,JsonRequestBehavior.AllowGet);
            */

            var plist = db.products.Where(e => e.categID == id).Select(e => new
            {
                id = e.id,
                name = e.name
            });

            return Json(plist,JsonRequestBehavior.AllowGet);
        }


        // GET: Inventories/Create
        public ActionResult Create()
        {
            ViewBag.categId = new SelectList(db.categories, "id", "name");
            ViewBag.pid = new SelectList(db.products, "id", "name");
            return View();
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,pid,categId,qty")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                db.inventories.Add(inventory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categId = new SelectList(db.categories, "id", "name", inventory.categId);
            ViewBag.pid = new SelectList(db.products, "id", "name", inventory.pid);
            return View(inventory);
        }

        // GET: Inventories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = db.inventories.Find(id);
            if (inventory == null)
            {
                return HttpNotFound();
            }
            ViewBag.categId = new SelectList(db.categories, "id", "name", inventory.categId);
            ViewBag.pid = new SelectList(db.products, "id", "name", inventory.pid);
            return View(inventory);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,pid,categId,qty")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categId = new SelectList(db.categories, "id", "name", inventory.categId);
            ViewBag.pid = new SelectList(db.products, "id", "name", inventory.pid);
            return View(inventory);
        }

        // GET: Inventories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory inventory = db.inventories.Find(id);
            if (inventory == null)
            {
                return HttpNotFound();
            }
            return View(inventory);
        }

        // POST: Inventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inventory inventory = db.inventories.Find(id);
            db.inventories.Remove(inventory);
            db.SaveChanges();
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
