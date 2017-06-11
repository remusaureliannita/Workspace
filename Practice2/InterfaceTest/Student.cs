using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Student : Person,IStudent
    {
        public String faculty { get; set; }

        public Student() : base()
        {
            faculty = "unassigned";
        }
        public Student(String name, int age, String faculty) : base(name, age)
        {
            this.faculty = faculty;
        }

        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}",name, age, faculty);
        }

        public void Init()
        {
            this.name = "StudInit";
            this.age = 110;
            this.faculty = "StudInit";

        }

        public void ChangeFaculty(string faculty)
        {
            this.faculty = faculty;
        }
    }
}
