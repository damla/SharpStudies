using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    // interface + virtual methods
    class Program
    {
        static void Main(string[] args)
        {
            // Just like interfaces, you can't create abstract classes as new.
            // Database database = new Database();

            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new Oracle();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            // complete method
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); // non complete method
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            // mandatory implementation only has Delete method
            Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
/*
 * Demo:
 * Add method is same for every dbs but delete differs.
 */