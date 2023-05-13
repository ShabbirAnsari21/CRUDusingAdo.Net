using CRUDADO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CRUDADO.Controllers
{
    public class TeacherController : Controller
    {
        public IConfiguration Configuration { get; }
        private readonly string connectionstring = "";

        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string constr = Configuration["getconn"].ToString();
            con = new SqlConnection(constr);

        }
        public TeacherController(IConfiguration configuration)
        {
            Configuration = configuration;
            connectionstring = Configuration["ConnectionStrings:DefaultConnection"];
        }
        

        public IActionResult Teacher()
        {
            connection();
            List<Teacher> teachers = new List<Teacher>();
            SqlCommand com = new SqlCommand("GetTeacherList", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                teachers.Add(

                    new Teacher
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Id"]),
                        Skills = Convert.ToString(dr["Sskill"]),
                        TotalStudents = Convert.ToInt32(dr["count"]),
                        Salary = Convert.ToInt32(dr["Salary"]),
                        AddedOn = Convert.ToDateTime(dr["dateTime"])
                        //Empid = Convert.ToInt32(dr["Id"]),
                        //Name = Convert.ToString(dr["Name"]),
                        //City = Convert.ToString(dr["City"]),
                        //Address = Convert.ToString(dr["Address"])

                    }
                    ); 
            }


        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
