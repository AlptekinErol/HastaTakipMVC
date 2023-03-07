using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class DoctorController : Controller
    {
        DoctorManager tblDoctor = new DoctorManager();
        BranchManager tblBranc= new BranchManager();
        CustomerReportManager tblCustomerReport = new CustomerReportManager();
       
        // GET: Doctor
        public ActionResult DoctorList()
        {
            dynamic modal = new ExpandoObject();
            modal.doktorVeri = tblDoctor.ListDoctor();
            modal.branchVeri = tblBranc.ListBranch();
            modal.raporVeri = tblCustomerReport.GetAllReports();
            //modal.total = modal.doktorVeri + modal.branchVeri;
            //modal.siraliDoctor = tblDoctor.
            return View(modal);
            
        }

        //public ActionResult DoctorDetail(int id)
        //{
        //    tblDoctor.ListDoctor(id);
        //    return ();
        //}
    }
}