using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(50)]
        public string CustomerSurname { get; set; }
        [MaxLength(12)]
        public string CustomerTC { get; set; }
        public DateTime SignDate { get; set; }
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Email { get; set; }
        [StringLength(50)]
        public string ImageUrl { get; set; }
        public bool AccStatus { get; set; }
        public int? PermissionID { get; set; }
        public virtual Permission Permission { get; set; }
        public int? HospitalID { get; set; }
        public virtual Hospital Hospital { get; set; }
        public int? GuestID { get; set; }
        public virtual Guest Guest { get; set; }

        ICollection<CustomerReport> CustomerReports { get; set; }







    }
}
