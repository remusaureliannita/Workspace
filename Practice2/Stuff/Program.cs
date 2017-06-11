using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff
{
    public sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double , double> op)
        {
            return op(radius);
        }

    }

    class Program
    {
        public static bool IsPalindrome(int arg)
        {
            int temp = arg;
            int aux = 0;

            while (temp > 0)
            {
                aux = aux * 10 + temp % 10;
                temp = temp / 10;
            }

            if (aux == arg)
                return true;
            else
                return false;    
        }
        public static int SumOfEvens(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            return sum;
        }
        public static void RemoveDuplicates(ref List<int> list)
        {
            list = list.Distinct().ToList();
        }
        public static String ReverseString(String str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);

            return new string(c);
        }
        public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
        {
            for(int i = 0; i < list.Count(); i++)
            {
                for(int j = 0; j < list.Count(); j++)
                {
                    if (list[i] + list[j] == sum)
                        return Tuple.Create(i, j);
                }
            }
            return null;
        }
        public static Tuple<int, int> MinMax(List<int> list)
        {
            int minim = list[0];
            int maxim = list[0];
            for(int i = 0; i < list.Count(); i++)
            {
                if (list[i] < minim)
                    minim = list[i];
                if (list[i] > maxim)
                    maxim = list[i];
            }

            return Tuple.Create(minim, maxim);
        }

        public static int CountNumbers(int[] arr, int lessThan)
        {
            int count = 0;
            if (arr[0] >= lessThan)
                return 0;
            else
            {
               for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < lessThan)
                        count++;
                }
            }
            return count;
        }
        public static int CountNumbers(List<int> list, int lessThan)
        {
            if (list[0] >= lessThan)
                return 0;
            else if (list.IndexOf(lessThan) == -1)
            {
                return list.Count;
            }
            else
            {
                return list.IndexOf(lessThan);
            }
           
         
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>{  4, 5, 6, 7, 8, 9 };
            //Tuple<int, int> indices = FindTwoSum(list, 12);
            //Console.WriteLine(indices.Item1 + " " + indices.Item2);
            Tuple<int, int> edges = MinMax(list);
            Console.WriteLine("Minim: {0}     Maxim: {1}", edges.Item1, edges.Item2);

            Console.WriteLine(CountNumbers(list, 11));

            

            Console.ReadKey();
        }
    }
}
