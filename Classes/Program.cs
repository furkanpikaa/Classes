using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            ProductManager productManager = new ProductManager();
            //productManager.Add();
            //productManager.Update();

            Customer customer = new Customer() {Id = 1, FirstName = "Furkan",
                LastName = "Sırdaş",
                City = "İstanbul"
            };

            Console.WriteLine(customer.FirstName + " " + customer.LastName);


            Console.ReadLine();
            
        }
    }
}
