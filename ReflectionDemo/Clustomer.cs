using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Customer
    {
        public int Id
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public Customer()
        {
            this.Id = Id;
            this.name = name;
        }
        public void PrintId()
        {
            Console.WriteLine("ID is {0}" + this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is {0}" + this.name);
        }
    }
}