using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Engin" },
                new Student{FirstName = "Furkan" },
                new Person{FirstName = "Salih" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }



    class Person
    {
        public int Id { get; set; }                 
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {

    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

}
