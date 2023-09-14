using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.EntityLayer
{
    public class Beverage : BaseEntity
    {
        [Key]
        public int BeverageID { get; set; }

        public int CategoryID { get; set; }
        public Category BeverageCategory { get; set; }
    }
}
