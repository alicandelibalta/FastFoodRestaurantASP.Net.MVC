using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.EntityLayer
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<Beverage> CategoryBeverage { get; set; }
        public List<Burger> CategoryBurger { get; set; }
        public List<Fry> CategoryFry { get; set; }
        public List<Sauce> CategorySauce { get; set; }


        public List<OrderCategory> ListOrderCategory { get; set; }
    }
}
