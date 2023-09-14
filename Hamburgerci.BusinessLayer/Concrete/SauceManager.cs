using Hamburgerci.BusinessLayer.Abstract;
using Hamburgerci.DataAccessLayer.Abstract;
using Hamburgerci.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.BusinessLayer.Concrete
{
    public class SauceManager : ISauceService
    {
        ISauceRepository _sauceRepo;
        public SauceManager(ISauceRepository sauceRepo)
        {
            _sauceRepo = sauceRepo;
        }
        public void TAdd(Sauce t)
        {
            _sauceRepo.Insert(t);
        }

        public void TDelete(Sauce t)
        {
            throw new NotImplementedException();
        }

        public List<Sauce> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Sauce t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Sauce t)
        {
            throw new NotImplementedException();
        }
    }
}
