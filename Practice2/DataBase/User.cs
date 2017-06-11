using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{

    public class User
    {
        public int id { get; set; }
        public String name { get; set; }


        public User()
        {
            this.id = -1;
            this.name = "unassigned";
        }
        public User(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

      
    }
}

