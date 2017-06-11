using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing
{
    public class Student : Person
    {
        String faculty;

        public Student():base()
        {
            this.faculty = "unassigned";
        }
        public Student(String name, int age, String faculty) : base(name, age)
        {
            this.faculty = faculty;
        }

        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}", name, age, faculty);
        }
    }
}
