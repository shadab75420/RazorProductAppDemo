using System.Collections.Generic;

namespace RazorProductApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public List<string> Categories { get; set; } = new List<string>();
    }
}