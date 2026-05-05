using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProductApp.Models;
using System.Collections.Generic;

namespace RazorProductApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Product NewProduct { get; set; } = new Product();

        public List<Product> Products { get; set; } = new List<Product>();

        public void OnGet()
        {
            NewProduct = new Product
            {
                Categories = new List<string> { "", "", "" }
            };
        }

        public void OnPost()
        {
            if (NewProduct != null)
            {
                while (NewProduct.Categories.Count < 3)
                {
                    NewProduct.Categories.Add("");
                }

                Products.Add(NewProduct);

                // Reset form
                NewProduct = new Product
                {
                    Categories = new List<string> { "", "", "" }
                };
            }
        }
    }
}