using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacess
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServiceCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();       
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            SqlServiceCustomerDal sqlServiceCustomerDal = new SqlServiceCustomerDal();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();

            customerManager.Update(sqlServiceCustomerDal);
            customerManager.Delete(oracleCustomerDal);
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "Sırdaş",
                Adress = "İstanbul"
            };

            Student student = new Student()
            {
                Id = 2,
                FirstName = "Kemal",
                LastName = "Demiroğ",
                Departmant = "Computer"
            };

            personManager.Add(customer);
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
