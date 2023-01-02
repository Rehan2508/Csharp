using CateringApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CateringApp.Controllers
{
    public class ProductsController : Controller
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CateringContext"].ToString());

        // GET: Products
        public ActionResult Index()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Product> listProduct = new List<Product>();
            foreach (DataRow dr in dt.Rows)
            {
                Product product = new Product();
                product.id = int.Parse(dr["Id"].ToString());
                product.name = dr["Name"].ToString();
                product.categoryId = int.Parse(dr["Category Id"].ToString());
                product.description = dr["Description"].ToString();
                product.photoPath = dr["Photo Path"].ToString();
                product.price = double.Parse(dr["Price"].ToString());
                listProduct.Add(product);
            }
            return View(listProduct);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Product ([Name], \"Category Id\",[Description],\"Photo Path\",Price) VALUES ('"+product.name+"', '"+product.categoryId+"', '"+product.description+"', '"+product.photoPath+"', '"+product.price+"')",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public ActionResult Edit(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Id = '" + id + "'",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Product product = new Product()
            {
                id = int.Parse(dt.Rows[0]["Id"].ToString()),
                name = dt.Rows[0]["Name"].ToString(),
                categoryId = int.Parse(dt.Rows[0]["Category Id"].ToString()),
                description = dt.Rows[0]["Description"].ToString(),
                photoPath = dt.Rows[0]["Photo Path"].ToString(),
                price = double.Parse(dt.Rows[0]["Price"].ToString())
            };
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Product SET [Name] = '"+product.name+"', \"Category Id\" = '"+product.categoryId+"', Description = '"+product.description+"', \"Photo Path\" = '"+product.photoPath+"', Price = '"+product.price+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
            finally { 
                conn.Close();
            }
        }

        public ActionResult Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Id = '" + id + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Product product = new Product()
            {
                id = int.Parse(dt.Rows[0]["Id"].ToString()),
                name = dt.Rows[0]["Name"].ToString(),
                categoryId = int.Parse(dt.Rows[0]["Category Id"].ToString()),
                description = dt.Rows[0]["Description"].ToString(),
                photoPath = dt.Rows[0]["Photo Path"].ToString(),
                price = double.Parse(dt.Rows[0]["Price"].ToString())
            };
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE Id = '"+id+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Product WHERE Id = '" + id + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Product product = new Product()
                {
                    id = int.Parse(dt.Rows[0]["Id"].ToString()),
                    name = dt.Rows[0]["Name"].ToString(),
                    categoryId = int.Parse(dt.Rows[0]["Category Id"].ToString()),
                    description = dt.Rows[0]["Description"].ToString(),
                    photoPath = dt.Rows[0]["Photo Path"].ToString(),
                    price = double.Parse(dt.Rows[0]["Price"].ToString())
                };
                return View(product);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}