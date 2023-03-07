using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerReportManager
    {
        GenericRepository<CustomerReport> repo = new GenericRepository<CustomerReport>();
        public List<CustomerReport> GetAllReports()
        {
            return repo.List();
        }

        public void DeleteReport(CustomerReport p)
        {
            repo.Delete(p);
        }

        public List<CustomerReport> GetAllReportsByID(int id)
        {
            var reports = repo.List().Where(d => d.CustomerID == id).ToList();

            return reports;
        }
        public void UpdateReport(CustomerReport p)
        {
            repo.Update(p);
        }
    }
}
