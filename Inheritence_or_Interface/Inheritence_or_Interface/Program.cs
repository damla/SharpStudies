using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * This solution is created to understand where to use inheritence and interfaces, also
 * what are the differences between them.
 */
namespace Inheritence_or_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            // We used PersonManager class to organize things.
            manager.Add(new Customer {
                Id = 1,
                FirstName = "Damla",
                LastName = "Example",
                Address = "Istanbul"
            });
            Student student = new Student
            {
                Id = 1409512,
                FirstName = "Yaprak",
                LastName = "Example",
                Department = "Computer Sciences"
            };
            Robot robot = new Robot
            {
                Id = 2,
                FirstName = "Robo",
                LastName = "Robot",
                Status = true // open
            };
            manager.Add(student);
            manager.Add(robot);
            // Another way to add objects.
            Console.ReadLine();
        }
    }

    // Interface has IName standard for example IPerson
    // The main idea is making fundamental properties to apply on all items
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
        // Mandatory field ended
        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Mandatory field ended
        public string Department { get; set; }
    }

    class Robot:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Mandatory field ended
        public Boolean Status { get; set; }
        /* 
         * After the addition of Robot object, we don't need
         * to changes parameters in PersonManager class 
         */
    }

    class PersonManager // to control data
    {
        public void Add(IPerson person) 
            /* 
             * Because of the implementation, IPerson involve both Student and 
             * Customer objects therefore, using IPerson as a parameter allows us
             * to use both objects.
             */ 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
