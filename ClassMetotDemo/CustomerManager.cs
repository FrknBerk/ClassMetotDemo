using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Id:" + customer.Id + " Ad:"+ customer.Name +
                " Soyad:"+ customer.Surname + " Mail:" +customer.Email+
                " Şifre:"+customer.Password + " Müşteri Eklendi ");
            //Console.WriteLine("Ad : " + customer.);
            //Console.ReadKey();
        }

        public void ListCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Id:" + customer.Id + " Ad:" + customer.Name +
                    " Soyad:" + customer.Surname + " Mail:" + customer.Email +
                    " Şifre:" + customer.Password + "\n");
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Id:" + customer.Id + " Ad:" + customer.Name +
                " Soyad:" + customer.Surname + " Mail:" +customer.Email +
                " Şifre:" +customer.Password + " Müşteri Silindi");
        }

    }
}
