using System;
using TestBoiko.Models;
using System.Linq;
using ConsoleTables;

namespace TestBoiko
{
    class PrinterShop
    {/*
        public void PrintAll(Shop shop)
        {
            if (shop == null)
            {
                throw new ArgumentNullException($"{nameof(shop)} in PrintAll");
            }

            foreach (var item in shop.Products)
            {
                Console.Write($"Name:{item.Name} ");
                Console.Write($"Id:{item.Id} ");
                Console.WriteLine($"CategoryId:{item.CategoryId}");
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in shop.Categories)
            {
                Console.Write($"Name:{item.Name} ");
                Console.WriteLine($"Id:{item.Id}");

            }
        }
        */
        public void PrinInTable(Shop shop)
        {
            

            var categoris = shop.Categories.ToDictionary(t => t.Id, t => t.Name);

            var table = new ConsoleTable("Product name", "Category name");

            foreach (var product in shop.Products)
            {
                table.AddRow(product.Name, categoris[product.CategoryId]);
            }

            table.Write(Format.Alternative);
            Console.WriteLine();
        }
    }
}
