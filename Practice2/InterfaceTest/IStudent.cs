using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public interface IStudent : IPerson
    {
        void ChangeFaculty(String faculty);
    }
}
