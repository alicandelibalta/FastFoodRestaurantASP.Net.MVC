using Hamburgerci.DataAccessLayer.Abstract;
using Hamburgerci.DataAccessLayer.Repository;
using Hamburgerci.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DataAccessLayer.EntityFramework
{
    public class EfSauceRepo : GenericRepository<Sauce>, ISauceRepository
    {
    }
}
