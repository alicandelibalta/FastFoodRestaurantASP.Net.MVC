using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.EntityLayer
{
    public class Burger : BaseEntity
    {
        [Key]
        public int BurgerID { get; set; }

        public int CategoryID { get; set; }
        public Category BurgerCategory { get; set; }
    }
}
