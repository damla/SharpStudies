using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    // If you think you can do same things with interface, do it with that.
    class Program
    {
        static void Main(string[] args)
        {
            // General person can be created.
            Person[] persons = new Person[] {
                new Customer
                {
                    Id = 4,
                    FirstName = "Damla",
                    LastName = "Test",
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Yagiz",
                    LastName = "Example",
                    Department = "CS"
                },
                new Person
                {
                    FirstName = "Yaprak"
                }
            };
            foreach( var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person // parent
    {
        // Object may only have one parent
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person // Child
    {
        /*
         * We see another difference from interface here,
         * which is we don't need to rewrite parent's 
         * properties again here.
         */
        public string City { get; set; }
    }
    class Student : Person // Chield
    {
        public string Department { get; set; }
    }
}
