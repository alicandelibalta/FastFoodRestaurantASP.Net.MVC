using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
    }
}
