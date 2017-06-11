using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr7
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte carte = new nr7.Carte("Somnoroase Pasarele", "Mihai Eminesu", "ASD");

            carte.Afisare();

            Console.WriteLine(carte.getDetails());

            Console.ReadKey();
        }
    }
}
