using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal:IRepository<Customer>
    {
        //Interfacelerde nesne üretilemez veya kullanılamaz (soyut alanlar olduğu için Abstract)
        // yazım şekli
        // Type MethodAdı();
        

    }
}
