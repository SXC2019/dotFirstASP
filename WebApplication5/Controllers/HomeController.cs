using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
  
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {        

            return View();
        }

        [HttpPost]
        public IActionResult Index(ModelStuudent student)
        {

           
            string connectionStri = "Data Source=DESKTOP-I446C2N;uid=sa;pwd=sql;Initial Catalog=Test";
            SqlConnection con = new SqlConnection(connectionStri);
            string sql = "insert into tblStudent values(@Roll,@FirstName)";
            //string sql = "delete from tblStudent where Roll=@Roll";
            //string sql = "update tblStudent set FirstName=@FirstName where Roll=@Roll";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Roll", student.Roll);
            command.Parameters.AddWithValue("@FirstName", student.FirstName);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            ViewBag.Info = "Data Saved Successfully";
            return View("Information");
        }

        [HttpPost]
        public  IActionResult Add()
        {
            int roll = Convert.ToInt32( Request.Form["txtRoll"]);
            string name = Request.Form["txtFirstName"];
            string connectionStri = "Data Source=DESKTOP-I446C2N;uid=sa;pwd=sql;Initial Catalog=Test";
            SqlConnection con = new SqlConnection(connectionStri);
            //string sql = "insert into tblStudent values(@Roll,@FirstName)";
            //string sql = "delete from tblStudent where Roll=@Roll";
            string sql = "update tblStudent set FirstName=@FirstName where Roll=@Roll";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Roll", roll);
           command.Parameters.AddWithValue("@FirstName", name);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            ViewBag.Info= "Data Saved Successfully";
            return View("Information");

        }

        [Route("Mero/con")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Mero/abt")]
        public IActionResult AboutUs()
        {
            return View("About");
        }

        [HttpGet]
        public IActionResult Add(int a)
        {
            
            

            string fname = Request.Query["txtFirst"];
            string lname = Request.Query["txtSecond"];

            string fullName = fname + lname;

            ViewBag.Info= fullName; 
            return View("Information");
        }

        public IActionResult Error()
        {

            return View("PageNotFound");
        }
    }
}
