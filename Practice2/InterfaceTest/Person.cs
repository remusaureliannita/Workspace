using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Person : IPerson
    {
        public String name { get; set; }
        public int age { get; set; }

        public Person()
        {
            name = "unassigned";
            age = 0;
        }
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine("{0}, {1}", name, age);
        }

        public void Init()
        {
            name = "PersonInit";
            age = 100;
        }
    }
}
