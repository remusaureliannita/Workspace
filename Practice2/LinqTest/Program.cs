using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "remus"));
            students.Add(new Student(2, "ana"));
            students.Add(new Student(3, "vlad"));
            students.Add(new Student(4, "edi"));
            students.Add(new Student(5, "cati"));
            students.Add(new Student(6, "anto"));


            List<Address> addresses = new List<Address>();
            addresses.Add(new Address(1, 1, "tudor"));
            addresses.Add(new Address(2, 2, "copou"));
            addresses.Add(new Address(3, 1, "pacurari"));
            addresses.Add(new Address(4, 4, "gara"));
            addresses.Add(new Address(5, 3, "tudor"));


            var temp = from student in students join address in addresses on student.id equals address.studId select new {
                studname = student.name,
                addname = address.address
            };

            foreach(var v in temp)
            {
                Console.WriteLine("{0}, {1}", v.studname, v.addname);
            }

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n.GetType());

            Console.ReadKey();
        }
    }
}
