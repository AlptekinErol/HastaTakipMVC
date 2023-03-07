using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BranchManager
    {
        GenericRepository<Branch> repository = new GenericRepository<Branch>();

        public List<Branch> ListBranch()
        {
            return (repository.List());
        }
    }
}
