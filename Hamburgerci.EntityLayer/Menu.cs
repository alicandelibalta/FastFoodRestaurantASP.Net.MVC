using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.EntityLayer
{
    public class Menu : BaseEntity
    {
        public int MenuID { get; set; }

        public List<OrderMenu> ListMenuOrder { get; set; }

    }
}
