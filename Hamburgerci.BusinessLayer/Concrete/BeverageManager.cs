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
    public class BeverageManager : IBeverageService
    {
        IBeverageRepository _beverageRepository;
        public BeverageManager(IBeverageRepository beverageRepository)
        {
            _beverageRepository = beverageRepository;
        }
        public void TAdd(Beverage t)
        {
            _beverageRepository.Insert(t);
        }

        public void TDelete(Beverage t)
        {
            throw new NotImplementedException();
        }

        public List<Beverage> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Beverage t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Beverage t)
        {
            throw new NotImplementedException();
        }
    }
}
