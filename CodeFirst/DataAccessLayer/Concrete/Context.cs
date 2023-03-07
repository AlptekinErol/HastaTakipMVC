using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerEnabledDbContext;

namespace DataAccessLayer
{
    public class Context:TrackerContext
    {
        
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerReport> CustomerReports { get; set; }
        public  DbSet<Doctor> Doctors{ get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}
