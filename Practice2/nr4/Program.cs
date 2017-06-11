using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr4
{
    class Program
    {

        static int[,] BuildMatrix(int[] n)
        {
            int[,] m = new int[n.Length,4];
            int[] x = { 1,10,100,1000};

            for(int i=0; i < n.Length; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    m[i, j] = n[i] * x[j];
                }
            }

            return m;
        } 

        static void Afisare(int [,] m)
        {
            int i = 0;
            foreach(int index in m)
            {
                Console.Write(index);
                i++;
                if(i == 4)
                {
                    Console.WriteLine();
                    i = 0;
                }

            }
        }

        static void Main(string[] args)
        {
            int[] N = { 1, 2, 3, 4, 5 };

            int[,] m = BuildMatrix(N);

            Afisare(m);

            Console.ReadKey();
        }
    }
}
