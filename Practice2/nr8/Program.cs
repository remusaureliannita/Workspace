using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\REMUS\Documents\Visual Studio 2015\Projects\Practice2\nr8\input.txt"))
            {
                String line;

                using (StreamWriter sw = new StreamWriter(@"C:\Users\REMUS\Desktop\output.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line.ToLower());
                    }
                }
            }
            Console.ReadKey();
        }

    }
}
