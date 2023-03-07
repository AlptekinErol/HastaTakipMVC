using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerReport
    {
        [Key]
        public int ReportID { get; set; }
        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int? DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int? HospitalID { get; set; }
        public virtual Hospital Hospital { get; set; }
        public int? GuestID { get; set; }
        public virtual Guest Guest { get; set; }
        [StringLength(50)]
        public string Complain { get; set; }
        public string Comment { get; set; }
        public DateTime SignDate { get; set; }
        [MaxLength(20)]
       
        public string Price { get; set; }
        public int? TreatmentID { get; set; }
        public virtual Treatment Treatment { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool ReportStatus { get; set; }


        //hasta id (hasta bilgileri için) , doktor id (doktor bilgileri için)
        //hastane id (hastane bilgileri) , guest id (refaketçi ) not necessary

    }
}
