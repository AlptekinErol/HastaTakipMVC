using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer;


namespace CodeFirst.Controllers
{

    public class LoginController : Controller
    {
        string mail;
        string pw;
        int id;
        CustomerManager db = new CustomerManager();
        DoctorManager db2 = new DoctorManager();


        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {

            var customer = db.GetAll();

            foreach (var item in customer)
            {
                id = item.CustomerID;
                mail = item.Email;
                pw = item.Password;
            }
            if (email == mail && password == pw)
            {
                Session["id"] = id;
                return RedirectToAction("UserAccount", "Customer");
            }
            else
            {
                ViewData["Message"] = "Hatalı Giriş";
                return View();
            }

        }
        [HttpGet]
        public ActionResult DoctorLogin()
        {
            return View();
        }
        [HttpPost]

        public ActionResult DoctorLogin(string email, string password)
        {
            var doctor = db2.ListDoctor();
            foreach (var doc in doctor)
            {
                mail = doc.Email;
                pw = doc.Password;
            }
            if (email == mail && password == pw)
            {
                return RedirectToAction("UserAccount", "Customer");
            }
            else
            {
                return View();
            }

            
        }
    }
}