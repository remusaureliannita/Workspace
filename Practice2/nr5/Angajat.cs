using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr5
{
    public class Angajat
    {
        public String nume { get; set; }
        public String prenume { get; set; }
        public double salariu;

        public double Salariu{
            get
            {
                return salariu;
            }
            set
            {
                if(value < 0)
                {
                    salariu = 0;
                }else
                {
                    salariu = value;
                }
            }
        }

        public Angajat()
        {
            this.nume = "unassigned";
            this.prenume = "unassigned";
            this.salariu = 0;
        }
        public Angajat(String nume,String prenume, double salariu)
        {
            this.nume = nume;
            this.prenume = prenume;

            if (salariu < 0)
            {
                this.salariu = 0;
            }
            else
            {
                this.salariu = salariu;
            }
        }

        public void Afisare()
        {
            Console.WriteLine("Nume: {0}", nume);
            Console.WriteLine("Prenume: {0}", prenume);
            Console.WriteLine("Salariu lunar: {0}", salariu);
            Console.WriteLine("Salariu anual: {0}", salariu * 12);
        }
    }
}
