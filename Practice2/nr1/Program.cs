using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sir = { 'A', 'B', 'C', 'a', 'b', 'c', '0', '1', '2', '$', '*', '+', '/' };

            foreach(char ch in sir)
            {
                Console.WriteLine((int)ch);
            }

            Console.ReadKey();
        }
    }
}
