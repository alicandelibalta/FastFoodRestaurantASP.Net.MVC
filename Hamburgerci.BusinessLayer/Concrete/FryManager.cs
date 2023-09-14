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
    public class FryManager : IFryService
    {
        IFryRepository _fryRepository;
        public FryManager(IFryRepository fryRepository)
        {
            _fryRepository = fryRepository;
        }
        public void TAdd(Fry t)
        {
            _fryRepository.Insert(t);
        }

        public void TDelete(Fry t)
        {
            throw new NotImplementedException();
        }

        public List<Fry> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Fry t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Fry t)
        {
            throw new NotImplementedException();
        }
    }
}
