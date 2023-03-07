using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        [StringLength(50)]
        public string DoctorName { get; set; }
        [StringLength(50)]
        public string DoctorSurname { get; set; }
        public bool DrAccStatus { get; set; }
        public int? BranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public int?  HospitalID { get; set; }
        public virtual Hospital Hospital { get;set; }
        public int? PermissionID { get; set; }
        public virtual Permission Permission { get; set; }
        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        ICollection<CustomerReport> CustomerReports { get; set; }
       

        //  hastane ve yetki foreign keyleri eksik
    }
}
