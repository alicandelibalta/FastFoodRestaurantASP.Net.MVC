using Hamburgerci.DataAccessLayer;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata.Ecma335;

namespace Hamburgerci.Presentation.Areas.Admin.Models
{
    public class ProductViewModel
    {
        //Context context1 = new Context();
        //public List<SelectListItem> SelectedCategory { get; set; }

        //public void GetCategory()
        //{
        //    SelectedCategory = context1.Categories.Select(a => 
        //                                                    new SelectListItem
        //                                                    { Text = a.Name,
        //                                                    Value = a.CategoryID.ToString(),
        //                                                    }).ToList();
        //}

        public string CategoryID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        //public int CategoryID { get; set; }
        //public virtual CategoryViewModel Category { get; set; }
        //public IEnumerable<SelectListItem> CategoryList { get; set; }
        //public static IEnumerable<SelectListItem> getCategories()
        //{
        //    using (var db = new Context())
        //    {
        //        List<SelectListItem> list = new List<SelectListItem>();
        //        var x = db.Categories.ToList();
        //        foreach (var y in x)
        //        {
        //            list.Add(new SelectListItem { Value = y.CategoryID.ToString(), Text = y.Name });
        //        }
        //        return list;
        //    }
        //}
    }
}
