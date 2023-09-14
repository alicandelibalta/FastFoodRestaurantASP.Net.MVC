using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.EntityLayer
{
    public class OrderMenu
    {
        [Key]
        public int OrdeMenuID { get; set; }
        public int OrderID { get; set; }
        public Order OrdersMenu { get; set; }
        public int MenuID { get; set; }
        public Menu MenusOrder { get; set; }
    }
}
