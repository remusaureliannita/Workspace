using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Student s1 = new Student();
            Employee e1 = new Employee();
            IPerson ip = new Person();



            ip.Display();

            

            Console.ReadKey();
        }
    }
}
