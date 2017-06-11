using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr7
{
    public class Carte
    {
        public String numeCarte { get; set; }
        public String numeAutor { get; set; }
        public String numeEditura { get; set; }

        public Carte()
        {
            numeCarte = "unset";
            numeAutor = "unset";
            numeEditura = "unset";
        }
        public Carte(String carte, String autor, String editura)
        {
            this.numeCarte = carte;
            this.numeAutor = autor;
            this.numeEditura = editura;
        }

        public void Afisare()
        {
            Console.WriteLine("Nume: {0}", numeCarte);
            Console.WriteLine("Autor: {0}", numeAutor);
            Console.WriteLine("Editura: {0}", numeEditura);
        }

        public String getDetails()
        {
            String details = null;

            details = numeCarte + " " + numeAutor + " " + numeEditura;

           return details;
        }
    }
}
