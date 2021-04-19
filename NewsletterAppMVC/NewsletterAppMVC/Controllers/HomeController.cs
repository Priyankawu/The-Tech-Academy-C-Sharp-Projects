using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly string connectionString = @"Data Source=HIRSHAARIA\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }

        //This method puts the information from signup form into the Database- Table: SignUps
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //This code chunk saves the below commented out code.
                using (NewsletterEntities db = new NewsletterEntities())
                {
                   
                    var signup = new SignUp();

                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    db.SignUps.Add(signup);
                    db.SaveChanges();          //only now saved to DB


                }
                    //connect to ado.net


                //    // queryString prevents user INJECTION. So never use raw user input in your query
                //    string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress, SocialSecurityNumber) VALUES
                //                        (@FirstName, @LastName, @EmailAddress, @SocialSecurityNumber)";        //don't put values straight here for injection safety
                ////at the end of using, connection will be cut off so no memory leaks. this is different using than on top
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);        //safe way of adding values
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                //    command.Parameters.Add("@SocialSecurityNumber", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;
                //    command.Parameters["@SocialSecurityNumber"].Value = socialSecurityNumber; 

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}
                return View("Success");
            }
        }

        //This method displays the information that was earlier stored in the database.
        //public ActionResult Admin()
        //{
         
        //    }
                //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from Signups";
                //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    connection.Open();
                //    SqlDataReader reader = command.ExecuteReader();
                //    while (reader.Read())
                //    {
                //        var signup = new NewsletterSignUp();
                //        signup.Id = Convert.ToInt32(reader["Id"]);
                //        signup.FirstName = reader["FirstName"].ToString();
                //        signup.LastName = reader["LastName"].ToString();
                //        signup.EmailAddress = reader["EmailAddress"].ToString();
                //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                //        signups.Add(signup);
                //    }
                //}
               
       // }
    }

}