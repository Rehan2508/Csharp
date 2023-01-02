using EmptyController.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace EmptyController.Controllers
{
    public class PatientsController : Controller
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalContext"].ToString());
        // GET: Patients
        public ActionResult Index()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Patient",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<Patient> list = new List<Patient>();
            
            foreach(DataRow dr in dt.Rows)
            {
                Patient patient = new Patient();
                //if (dr["Id"].ToString() != null)
                    patient.id = int.Parse(dr["Id"].ToString());
               // else
                    //patient.id = 10001;
                patient.name = dr["Name"].ToString();
                patient.ailment = dr["Ailment"].ToString();
                list.Add(patient);
            }
            return View(list);
            //bool check = false;
            /*if (check)
            {
                ViewBag.Message = "you are already Registered in Hospital";

                ViewData["msg"] = "This is your second visit";

                TempData["display"] = "check at the counter for discount availability";
            }
            else
            {
                ViewBag.Message = "please complete your Registeration process";

                ViewData["msg"] = "please complete your Registration process 2";

                TempData["display"] = "please complete your Registration process 3";
            }*/
            
            /*
            ViewBag.Message = "view Bag";

            ViewData["msg"] = "View Data";

            TempData["display"] = "Temp Data";

            Session["show"] = "Session message";

            if (check == false)
                return RedirectToAction("GetPatient");
            else
                return View();  //it has 8 overloads*/

            //ViewBag, ViewData, TempData
            //ViewBag.Message = "Welcome to MVC Session";

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Patient p)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Patient VALUES('"+1001+"','"+p.name+"','"+p.ailment+"')",conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }
            finally
            {
                conn.Close();
            }
        }

        public ActionResult Edit(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Id = '"+id+"'",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Patient patient = new Patient() {
                id = int.Parse(dt.Rows[0]["Id"].ToString()),
                name = dt.Rows[0]["Name"].ToString(),
                ailment = dt.Rows[0]["ailment"].ToString()
            };
            return View(patient) ;
        }

        [HttpPost]
        public ActionResult Edit(Patient p)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Patient SET [Name] = '"+p.name+"', Ailment = '"+p.ailment+"' WHERE Id = '"+p.id+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.message = ex.Message;
                return View(p);
            }
            finally 
            { 
                conn.Close(); 
            }
        }

        public ActionResult Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Id = '" + id + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Patient patient = new Patient()
            {
                id = int.Parse(dt.Rows[0]["Id"].ToString()),
                name = dt.Rows[0]["Name"].ToString(),
                ailment = dt.Rows[0]["ailment"].ToString()
            };
            return View(patient);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Patient WHERE id = '"+id+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Patient WHERE Id = '" + id + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Patient patient = new Patient()
                {
                    id = int.Parse(dt.Rows[0]["Id"].ToString()),
                    name = dt.Rows[0]["Name"].ToString(),
                    ailment = dt.Rows[0]["ailment"].ToString()
                };
                ViewBag.message = ex.Message;
                return View(patient);
            }
            finally
            {
                conn.Close();   
            }
        }

        public ActionResult GetPatient(int? id)
        {
            if (id == 1)
            {
                ViewBag.message = "your id is : " + id;
            }
            else
                ViewBag.message = "invalid id";
            return View();
        }
    }
}