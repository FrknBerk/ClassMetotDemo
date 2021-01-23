using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Furkan Berk";
            customer1.Surname = "Akdaş";
            customer1.Email = "deneme@gmail.com";
            customer1.Password = 1234;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Lorem";
            customer2.Surname = "Ipsul";
            customer2.Email = "lorem@hotmail.com";
            customer2.Password = 4321;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Test";
            customer3.Surname = "Deneme";
            customer3.Email = "testdeneme@outlook.com";
            customer3.Password = 3222;



            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager manager = new CustomerManager();

            manager.AddCustomer(customer1);

            Console.WriteLine("\n\n");

            manager.ListCustomer(customers);

            Console.WriteLine("\n\n");

            manager.DeleteCustomer(customer3);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
