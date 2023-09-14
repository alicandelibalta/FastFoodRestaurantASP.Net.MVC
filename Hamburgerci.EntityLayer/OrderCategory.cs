using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.EntityLayer
{
    public class OrderCategory
    {
        [Key]
        public int OrderCategoryID { get; set; }
        public int OrderID { get; set; }
        public Order OrdersCategory { get; set; }
        public int CategoryID { get; set; }
        public Category CategoriesOrder { get; set; }
    }
}
