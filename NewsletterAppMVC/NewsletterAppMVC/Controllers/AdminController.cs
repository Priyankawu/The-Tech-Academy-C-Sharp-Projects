using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.ViewModels;
using NewsletterAppMVC.Models;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())    //this gives us access to the DB 
            {
                //Entity Framework allows to do queries right here instead of doing queries against SQL. 
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();  //only the signups that have not been unsubscribe/removed
                //USING LINQ 
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;

                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())    //establishes a connection with a database
            {
                var signup = db.SignUps.Find(Id);   //finds item with the Id
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}