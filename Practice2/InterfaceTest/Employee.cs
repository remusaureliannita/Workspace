using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Employee : Student, IStudent, ICommon
    {
        public String job { get; set; }

        public Employee() : base()
        {
            this.job = "unassigned";
        }
        public Employee(String name, int age, String faculty, String job) : base(name, age, faculty)
        {
            this.job = job;
        }
        

        public void CommonMethod()
        {
            Console.WriteLine("Common Method");
        }

        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", name, age, faculty, job);
        }

        public void Init()
        {
            this.name = "EmpInit";
            this.age = 33;
            this.faculty = "EmpInit";
            this.job = "EmpInit";
        }
    }
}
