using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnıtsInStock = 3;

            // Ayrı ayrı vermeden class'ın yanında tanımlama yapılabilir
            Product product2 = new Product {Id=2, CategoryId=5, UnıtsInStock=5, ProductName="Kalem"is, UnitPrice=35};

            //PascalCase  //camelCase
            //case sensitive //sol taraf stack da oluşturur new den sonra heap de
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool... değer tip
            //diziler,class,abstract class, interface... referans tip
            //ref out
        }
    }
}
