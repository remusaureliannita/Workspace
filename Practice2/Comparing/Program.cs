using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("person", 1);
            Person p2 = new Person("person", 1);
            Person p3 = new Person("another", 2);

            Console.WriteLine(p1 == p2);
        
            Console.WriteLine(p1 == p3);

            List<Person> list = new List<Person>();
            list.Add(new Person("remus", 21));
            list.Add(new Person("nicu", 31));
            list.Add(new Person("ana", 22));
            list.Add(new Person("bogdan", 19));
            list.Add(new Person("lili", 21));
            list.Add(new Person("anca", 20));

            list.Sort();

            foreach(Person p in list)
            {
                Console.WriteLine("{0}, {1}", p.name, p.age);
            }

            Console.ReadKey();
        }
    }
}
