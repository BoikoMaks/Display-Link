using System.Collections.Generic;

namespace TestBoiko.Models
{
    internal class Shop
    {
        public List<Product> Products;

        public List<Category> Categories;
        public static Shop Empty => new Shop { Products = new List<Product>(), Categories = new List<Category>() };
    }
}
