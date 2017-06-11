using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing
{
    public class Person : IComparable
    {
        public String name { get; set; }
        public int age { get; set; }

        public Person()
        {
            this.name = "unassigned";
            this.age = 0;
        }
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object obj)
        {
           if(obj == null)
            {
                return false;
            }

            Person p = obj as Person;

            if((object)p == null)
            {
                return false;
            }

            return (name == p.name) && (age == p.age);
        }

        public bool Equals(Person p)
        {
            if((object)p == null)
            {
                return false;
            }

            return (name == p.name) && (age == p.age);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if(p1.age == p2.age && p1.name == p2.name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Person p1, Person p2)
        {
            if (p1.age == p2.age && p1.name == p2.name)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void Display()
        {
            Console.WriteLine("{0}, {1}", name, age);
        }

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            return this.name.CompareTo(p.name);
        }
    }

}
