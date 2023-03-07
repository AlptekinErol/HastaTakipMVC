using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class DoctorManager
    {
        GenericRepository<Doctor> repository = new GenericRepository<Doctor>();
        Doctor doc1 = new Doctor(); 
        public List<Doctor> ListDoctor()
        {
            return (repository.List());
        }

        public void UpdateDoctor(Doctor doctor)
        {
            repository.Update(doctor);
        }

        //public List<Doctor> ListDoctorDetail(int id)
        //{
        //       if(id == )

        //    return (repository.List());
        //}




    }
}
