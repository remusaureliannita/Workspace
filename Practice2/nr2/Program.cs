using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr2
{
    class Program
    {

        static void Afisare(int [,] a)
        {
            for(int i = 0; i < a.Rank; i++)
            {
                for(int j = 0; j < a.Rank; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static int[,] Adunare(int[,] a, int[,] b)
        {
            int[,] res = new int[a.Rank , a.Rank];

            for(int i = 0; i < res.Rank; i++)
            {
                for(int j = 0; j < res.Rank; j++)
                {
                    res[i, j] = a[i, j] + b[i, j];
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] b = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

            Afisare(a);

            Console.ReadKey();
        }
    }
}
