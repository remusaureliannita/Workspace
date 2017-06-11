using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    class Program
    {
        static void DisplayList(List<Person> list)
        {
            foreach(Person p in list)
            {
                p.Display();
            }
        }


        static void Main(string[] args)
        {
            DataBase db = new DataBase();


            Stopwatch Timer = new Stopwatch();

            String str = "";
            Timer.Start();
            for(int i = 0; i < 10000; i++)
            {
                str = str + i;
            }
            Timer.Stop();
            Console.WriteLine("Time elapsed: {0}", Timer.Elapsed);

            Timer.Reset();
            StringBuilder sb = new StringBuilder("");
            Timer.Start();
            for(int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }
            Timer.Stop();
            Console.WriteLine("Time elapsed: {0}", Timer.Elapsed);



            String a = "ana";
            String b = a; 
            

            Console.WriteLine(ReferenceEquals(a, b));


            Console.ReadKey();
        }
    }
}
