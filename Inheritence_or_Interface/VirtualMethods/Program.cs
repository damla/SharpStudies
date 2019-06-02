﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    // Important subject to understand inheritence.
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        // by the virtual methods, we have ability to override.
        public virtual void Add() 
        {
            Console.WriteLine("Added by default.");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default.");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            base.Add(); // base means Database(parent)
        }
    }
    class MySql : Database
    {

    }
}
