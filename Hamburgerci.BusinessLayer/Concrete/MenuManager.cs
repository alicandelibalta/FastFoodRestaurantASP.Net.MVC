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
    public class MenuManager : IMenuService
    {
        IMenuRepository _menuRepository;

        public MenuManager(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public void TAdd(Menu t)
        {
            _menuRepository.Insert(t);

        }

        public void TDelete(Menu t)
        {
            throw new NotImplementedException();
        }

        public List<Menu> TGetList()
        {
            return _menuRepository.GetList();
        }

        public void TInsert(Menu t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Menu t)
        {
            throw new NotImplementedException();
        }
    }
}
