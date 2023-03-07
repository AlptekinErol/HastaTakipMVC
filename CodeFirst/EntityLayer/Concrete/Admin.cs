using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerEnabledDbContext;

namespace EntityLayer.Concrete
{
    [TrackChanges]
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(50)]
        public string AdminName { get; set; }
        [StringLength(50)]
        public string AdminSurname { get; set; }
        [MaxLength(20)]
        [SkipTracking]
        public string Password { get; set; }
        public DateTime SignDate { get; set; }
        [SkipTracking]
        [StringLength(50)]
        public string ImageUrl{ get; set; }
   
        [StringLength(20)]
        public string Email { get; set; }
        
        [SkipTracking]
        public bool AdminAccStatus{ get; set; }
        public virtual int? PermissionID { get; set; }
        public virtual Permission Permission{ get; set; }
       


        //yetki ID foreign key eksik

    }
}
