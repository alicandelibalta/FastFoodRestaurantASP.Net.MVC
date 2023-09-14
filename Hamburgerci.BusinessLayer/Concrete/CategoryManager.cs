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
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void TAdd(Category t)
        {
            _categoryRepository.Insert(t);
        }

        public void TDelete(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> TGetList()
        {
            return _categoryRepository.GetList();
        }

        public void TInsert(Category t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
