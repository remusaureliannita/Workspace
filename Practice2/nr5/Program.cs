using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr5
{
    class Program
    {
        static void Main(string[] args)
        {
            Angajat a1 = new Angajat();
            Angajat a2 = new Angajat("Nita", "Remus", 2000);

  

            a2.Afisare();

            a2.Salariu = a2.Salariu + a2.Salariu * 0.1;

            a2.Afisare();

            Console.ReadKey();
        }
    }
}
