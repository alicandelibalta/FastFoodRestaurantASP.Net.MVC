using Hamburgerci.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.EntityLayer
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<OrderMenu> ListOrderMenu { get; set; }
        public List<OrderCategory> ListOrderCategory { get; set; }
        public OrderSize OrderSizeOrder { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
