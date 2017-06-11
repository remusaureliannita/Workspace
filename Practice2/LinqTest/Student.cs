using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Student
    {
        public int id { get; set; }
        public String name { get; set; }

        public Student()
        {
            this.id = 0;
            this.name = "unassigned";
        }
        public Student(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
