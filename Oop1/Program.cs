using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1, CategoryId = 2, ProductName = "Masa", UnitInStock = 3, UnitPrice = 300 };
            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitInStock = 5, UnitPrice = 3 };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
