using Hamburgerci.BusinessLayer.Abstract;
using Hamburgerci.DataAccessLayer.Abstract;
using Hamburgerci.EntityLayer;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.BusinessLayer.Concrete
{
    public class BurgerManager : IBurgerService
    {
        IBurgerRepository _burgerRepo;
        public BurgerManager(IBurgerRepository burgerRepo)
        {
            _burgerRepo = burgerRepo;
        }
        public List<Burger> TGetList()
        {
            return _burgerRepo.GetList();
        }

        public void TAdd(Burger t)
        {
            _burgerRepo.Insert(t);
        }

        public void TDelete(Burger t)
        {
            _burgerRepo.Delete(t);
        }

        public void TInsert(Burger t)
        {
            _burgerRepo.Insert(t);
        }

        public void TUpdate(Burger t)
        {
            _burgerRepo.Update(t);
        }
    }
}
