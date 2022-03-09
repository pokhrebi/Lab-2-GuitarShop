using System.Collections.Generic;

//Bhakti Pokhrel
namespace GuitarShop.Models
{
    public class ProductListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public string SelectedCategory { get; set; }
        public string CheckActivityCategory(string category) => category == SelectedCategory ? "active" : "";
    }
}
