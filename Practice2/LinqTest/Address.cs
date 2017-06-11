using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Address 
    {
        public int addId { get; set; }

        public int studId { get; set; }
        public String address { get; set; }

        public Address()
        {
            addId = 0;
            address = "unassigned";
        }
        public Address(int addId, int studId, String address)
        {
            this.addId = addId;
            this.studId = studId;
            this.address = address;
        }
    }
}
