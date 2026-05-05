using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProductApp.Models;
using System.Linq;

namespace RazorProductApp.Pages
{
    public class ProductDetailsModel : PageModel
    {
        // FIXED (nullable)
        public Product? Product { get; set; }

        public void OnGet(int id)
        {
            Product = IndexModel.Products.FirstOrDefault(p => p.ProductID == id);
        }
    }
}