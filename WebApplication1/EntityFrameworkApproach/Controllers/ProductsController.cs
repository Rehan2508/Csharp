using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using DAL.Models;
using Microsoft.AspNet.Identity;
using static System.Web.Razor.Parser.SyntaxConstants;

namespace EntityFrameworkApproach.Controllers
{
    public class ProductsController : Controller
    {
        private CateringContext db = new CateringContext();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.products.Include(p => p.categ);
            return View(products.ToList());
        }

        public ActionResult SelectedProducts(int id)
        {
            var products = db.products.Include(p => p.categ).Where(e => e.categID == id);
            return View(products.ToList());
        }

        
        [HttpPost]
        public ActionResult SelectedProducts(List<Product> plist)
        {
            try
            {
                foreach (Product p in plist)
                {
                    if (p.check)
                    {
                        Purchase p1 = new Purchase();
                        p1.name = p.name;
                        p1.price = p.price;
                        p1.qty = 10;
                        p1.prodID = p.id;
                        db.purchases.Add(p1);
                    }
                }
                db.SaveChanges();
                Session["Items"] = db.purchases.ToList().Count();
                TempData["Message"] = "Success";
                return RedirectToAction("SelectCategory", "Categories");
            }
            catch(Exception ex)
            {
                TempData["Message"] = ex.Message;
                return View(plist);
            }
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.categID = new SelectList(db.categories, "id", "name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,categID,price")] Product product, HttpPostedFileBase[] photoPath)
        {
            var path = "";
            var filePath = "";
            foreach (var photo in photoPath)
            {
                var fileName = Path.GetFileName(photo.FileName);
                filePath = "~/Content/Images/" + fileName;
                path = Path.Combine(Server.MapPath(filePath));
                photo.SaveAs(path);
            }

            if (ModelState.IsValid)
            {
                product.photoPath = filePath;
                db.products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categID = new SelectList(db.categories, "id", "name", product.categID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.categID = new SelectList(db.categories, "id", "name", product.categID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,categID,photoPath,price")] Product product)
        {          

            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categID = new SelectList(db.categories, "id", "name", product.categID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.products.Find(id);
            db.products.Remove(product);
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
