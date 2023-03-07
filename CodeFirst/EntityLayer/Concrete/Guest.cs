using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        [StringLength(50)]
        public string GuestName { get; set; }
        [StringLength(50)]
        public string GuestSurname { get; set; }
        [StringLength(50)]
        public string GuestTC { get; set; }

        [StringLength(20)]
        public string Email { get; set; }
        // Guest yetki ve 
        [StringLength(50)]
        public string Password { get; set; }
        public bool GuestAccStatus  { get; set; }
        public int? PermissionID { get; set; }
        [StringLength(50)]
        public string ImageUrl { get; set; }
        public virtual Permission Permission { get; set; }
        ICollection<CustomerReport> CustomerReports { get; set; }
        ICollection<Customer> Customers { get; set; }
        
    }
}
