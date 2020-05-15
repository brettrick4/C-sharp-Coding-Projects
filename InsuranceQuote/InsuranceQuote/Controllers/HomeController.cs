using InsuranceQuote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InsuranceQuote;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InsuranceQuote;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                string queryString = @"INSERT INTO GetQuotes (FirstName, LastName, EmailAddress) VALUES 
                                    (@FirstName, @LastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    //command.Parameters.Add("@Quote", SqlDbType.Money);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    //command.Parameters["@Quote"].Value = quote;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("DetailsPage");
            }
        }


        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, Firstname, LastName EmailAddress from GetQuote";
            List<InsuranceGetQuote> getquotes = new List<InsuranceGetQuote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var getquote = new InsuranceGetQuote();
                    getquote.Id = Convert.ToInt32(reader["Id"]);
                    getquote.firstName = reader["FirstName"].ToString();
                    getquote.lastName = reader["LastName"].ToString();
                    getquote.emailAddress = reader["EmailAddress"].ToString();
                    //getquote.quote = reader["Quote"].ToInt32();
                    getquotes.Add(getquote);
                }
            }
            return View(getquotes);

        }
    }
}