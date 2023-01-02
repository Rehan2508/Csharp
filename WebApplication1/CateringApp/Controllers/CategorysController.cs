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
    public class CategorysController : Controller
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CateringContext"].ToString());

        // GET: Categorys
        public ActionResult Index()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Category", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            List<Category> category = new List<Category>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Category c = new Category();
                c.id = int.Parse(dr["Id"].ToString());
                c.name = dr["Name"].ToString();
                c.photoPath = dr["Photo Path"].ToString();
                category.Add(c);
            }
            return View(category);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category c)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Category([Name], \"Photo Path\") VALUES('"+c.name+"', '"+c.photoPath+"')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(c);
            }
            finally
            {
                conn.Close();
            }
        }

        public ActionResult Edit(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Category WHERE Id = '" + id + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Category c = new Category()
            {
                id = int.Parse(dt.Rows[0]["Id"].ToString()),
                name = dt.Rows[0]["Name"].ToString(),
                photoPath = dt.Rows[0]["Photo Path"].ToString()
            };
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Category c)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Category SET [Name] = '"+c.name+"', \"Photo Path\" = '"+c.photoPath+"' WHERE Id = '"+c.id+"'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(c);
            }
            finally 
            { 
                conn.Close(); 
            }
        }

        public ActionResult Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Category WHERE Id = '" + id + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Category c = new Category()
            {
                id = int.Parse(dt.Rows[0]["Id"].ToString()),
                name = dt.Rows[0]["Name"].ToString(),
                photoPath = dt.Rows[0]["Photo Path"].ToString()
            };
            return View(c);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Category WHERE Id = '"+id+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Category WHERE Id = '" + id + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Category c = new Category()
                {
                    id = int.Parse(dt.Rows[0]["Id"].ToString()),
                    name = dt.Rows[0]["Name"].ToString(),
                    photoPath = dt.Rows[0]["Photo Path"].ToString()
                };
                ViewBag.Message = ex.Message;
                return View(c);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}