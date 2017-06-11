using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTest
{
    public class Cat 
    {
        public int Age { get; set; }
        public String Name { get; set; } 

        public int Price { get; set; }

        public Cat(String name, int age, int price)
        {
            this.Age = age;
            this.Name = name;
            this.Price = price;
        }

        public static bool operator ==(Cat c1, Cat c2)
        {
            if (c1.Name == c2.Name && c1.Age == c2.Age && c1.Price == c2.Price)
                return true;
            else
                return false;
        }
        public static bool operator !=(Cat c1, Cat c2)
        {
            if (c1.Name != c2.Name || c1.Age != c2.Age || c1.Price != c2.Price)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            Cat cat = (Cat)obj;

            if (this.Age == cat.Age && this.Name == cat.Name && this.Price == cat.Price)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat>();

            cats.Add(new Cat("Kitty", 2, 200));
            cats.Add(new Cat("Roxy", 2, 300));
            cats.Add(new Cat("Curry", 5, 400));
            cats.Add(new Cat("Liza", 2, 400));
            cats.Add(new Cat("Amy", 1, 300));
            cats.Add(new Cat("ASdas", 3, 400));

            Cat cat = new Cat("Liza", 2, 400);

            cats.Remove(cat);

            foreach(Cat c in cats)
            {
                Console.WriteLine("{0}, {1}", c.Name, c.Price);
            }



            Stack<Cat> catsStack = new Stack<Cat>();
            catsStack.Push(new Cat("Kitty", 2, 200));
            catsStack.Push(new Cat("Roxy", 2, 300));
            catsStack.Push(new Cat("Curry", 5, 400));
            catsStack.Pop();

            foreach (Cat c in catsStack)
            {
                Console.WriteLine("{0}, {1}", c.Name, c.Price);
            }
            
            



            Console.ReadKey();
        }
    }
}
