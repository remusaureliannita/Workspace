using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{

    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();

            db.AddUser(1, "Remus");
            db.AddUser(2, "Ana");
            db.AddUser(3, "Hagi");
            db.AddUser(4, "Stefan");
            db.AddUser(5, "Gigi");

            db.RemoveUser(3);

            db.Display();

            User u1 = new User(6, "Dan");
            User u2 = new User(6, "Dan");

            if(u1 == u2)
            {
                Console.WriteLine("TRUE");
            }

            Console.ReadKey();
        }
    }
}

