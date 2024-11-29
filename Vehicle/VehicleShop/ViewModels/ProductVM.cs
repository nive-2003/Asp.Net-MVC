//using Microsoft.AspNetCore.Mvc.Rendering;
using Vehicle.Model;

namespace VehicleShop.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
