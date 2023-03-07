using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.Ajax.Utilities;

namespace CodeFirst.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager db;
        CustomerReportManager db2 = new CustomerReportManager();
       
        // GET: Customer
        public ActionResult Index()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.value = db.GetCustomer();
            mymodel.value2 = db2.GetAllReports();


            return View(mymodel);
        }
        public ActionResult UserAccount()
        {
            var deger = (int)Session["id"];
           // model oluşturup datayı ekleyip yolluyoruz
            dynamic report = new ExpandoObject();
            report.value = db2.GetAllReportsByID(deger);
            report.value2 = deger;
            return View(report);
        }
    }
}