using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    public class Student : Person, IStudent
    { 
        public int grade
        {
            get
            {
                return grade;
            }

            set
            {
                if (value < 0)
                {
                    grade = 0;
                }
            }
        }


        public Student() : base()
        {
            grade = -1;
        }
        public Student(String name, int age, int grade) : base(name, age)
        {
            this.grade = grade;
        }

        public override void Display()
        {
            Console.WriteLine("{0}, {1}, {2}", name, age, grade);
        }

       
    }
}
