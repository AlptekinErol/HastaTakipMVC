using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Concrete
{
    [TrackChanges]
    public class Permission
    {
        
        [Key]
        public int PermissionID { get; set; }
        [StringLength(50)]
        public string PermissionName { get; set; }
        public bool PermissionStatus { get; set; }
        ICollection<Admin> Admins { get; set;}
        ICollection<Customer> Customers { get; set;}
        ICollection<Doctor> Doctors { get; set;}
        ICollection<Guest> Guests { get; set;}  

    }
}
