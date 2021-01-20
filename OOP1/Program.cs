using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ıd = 1;
            product1.CategoryId = 2; //mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { ıd = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1); //parantez içine ekle ama neyi ekleyim cevabını yazıyoruz.

            // int ,double, bool .... değer tip---atamalar değer üzerinden olur, bağlantı kopar. STACK
            //diziler, class, abstract, interface ..... referans tip --- bellekteki yeri getirir. HEAP

        }
    }
}
