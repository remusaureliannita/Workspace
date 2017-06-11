using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    public class Person : IPerson, IComparable
    {
        public String name { get; set; }
        public int age { get; set; }
        
        public Person()
        {
            name = "unassigned";
            age = -1;
        }
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Display()
        {
            Console.WriteLine("{0}, {1}", name, age);
        }

        public virtual int CompareTo(object obj)
        {
            Person p = (Person)obj;

            if (this.age > p.age)
                return 1;
            else if (this.age < p.age)
                return -1;
            else
                return 0;

        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (p1.name == p2.name && p1.age == p2.age)
                return true;
            else
                return false;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            if (p1.name != p2.name || p1.age != p2.age)
                return true;
            else
                return false;
        }
    }
}
