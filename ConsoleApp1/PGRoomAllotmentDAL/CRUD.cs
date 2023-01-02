using PGRoomAllotmentDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGRoomAllotmentDAL
{
    public class CRUD
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NewConnection"].ToString());

        public void Display(List<Rooms> list)
        {
            foreach (Rooms room in list)
            {
                string str = String.Format("{0,-5} | {1,-15} | {2,-1} | {3,-15} | {4,-15} | {5,-5} | {6,-5} | {7,-15}",room.roomNo,room.name,room.contactNo,room.homeCity,room.homeState,room.rent,room.deposite,room.companyName);
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }

        public void GetTable()
        {
            SqlCommand cmd = new SqlCommand("RoomsTableView", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Rooms> list = new List<Rooms>();
            foreach (DataRow dr in dt.Rows)
            {
                Rooms rooms = new Rooms();
                rooms.roomNo = int.Parse(dr["Room Number"].ToString());
                rooms.name = dr["Name"].ToString();
                rooms.contactNo = dr["Contact Number"].ToString();
                rooms.homeCity = dr["Home City"].ToString();
                rooms.homeState = dr["Home State"].ToString();
                rooms.rent = double.Parse(dr["Rent"].ToString());
                rooms.deposite = double.Parse(dr["Deposite"].ToString());
                rooms.companyName = dr["Company Name"].ToString();

                list.Add(rooms);
            }

            Display(list);
        }

        public string InsertIntoTable(Rooms room)
        {
            string message = "Insert successful";
            SqlCommand cmd = new SqlCommand("RoomsTableInsert",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Name",room.name);
            cmd.Parameters.AddWithValue("@ContactNumber",room.contactNo);
            cmd.Parameters.AddWithValue("@HomeCity",room.homeCity);
            cmd.Parameters.AddWithValue("@HomeState", room.homeState);
            cmd.Parameters.AddWithValue("@Rent", room.rent);
            cmd.Parameters.AddWithValue("@Deposite",room.deposite);
            cmd.Parameters.AddWithValue("@CompanyName",room.companyName);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch(Exception ex)
            {
                message = "Insert Unsuccessful : " + ex.Message;
                return message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
