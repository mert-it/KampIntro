using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Engin";
            customer1.CustomerSurname = "Demiroğ";
            customer1.TcNumber = "12345689798";

            //Kodlama.io tüzel müşteri

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1235644689";

            //SOLID
            // Customer sınıfı hem individualı hem de corporate'i tutabiliyor. inheritance dan dolayı.
            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager(); // instance oluşturmak zorundayız.
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
