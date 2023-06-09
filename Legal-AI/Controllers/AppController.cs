using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.Data.SqlClient;
using Legal_AI.Models;

namespace Legal_AI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        [HttpPost]
        [Route("api/account/login")]
        public IActionResult Login(User user)

        {
            // Perform login logic
            // Example code to validate the user credentials

            if (IsValidUser(user))
            {
                return Ok();
            }
            else
            {
                return Content(HttpStatusCode.Unauthorized, "Invalid username or password");
            }
        }

        private IActionResult Content(HttpStatusCode unauthorized, string v)
        {
            throw new NotImplementedException();
        }

        private bool IsValidUser(User user)
        {
            return user.Email == "admin" && user.Password == "password";
        }
        [HttpPost]
        [Route("api/account/register")]
        public IActionResult Register(User user)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-40JAMN6\\PROMACT;Initial Catalog=Legal_AI_DB;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                string query = "INSERT INTO Users (Email,Password,Designation) VALUES (@Email,@Password,@Designation )";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Designation", user.Desgination);
                command.ExecuteNonQuery();
            }

            return Ok();
        }

        private IActionResult Ok()
        {
            throw new NotImplementedException();
        }
    }


  
}

public class User
{
    public object Email { get; internal set; }
    public string Password { get; set; }
    public object Desgination { get; internal set; }
}


