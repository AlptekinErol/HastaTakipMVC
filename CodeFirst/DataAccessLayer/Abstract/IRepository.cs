using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {

        // Generic Repository oluşturmak için bu interface sayesinde
        // projede kullanılacak tüm methodlar Interface üzerinde depolanıyor
        //Generic Repository class'ı üzerinde ise ilgili class paramatre olarak yollanılıp kalıtım yapılarak bu methodlara ulaşılıyor
        //bknz: GenericRepository.cs Satır 11
        // son olarak diğer tüm interface class'ları da bu interface üzerinden kalıtılarak kullanılıyor
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);   
        List<T> List(Func<T, bool> filter);

    }
}
