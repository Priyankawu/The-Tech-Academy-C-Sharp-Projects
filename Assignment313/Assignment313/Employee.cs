using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment313
{
    public class Employee
    {
        public int Id;

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }
        public static bool operator !=(Employee a, Employee b)
        {
            return (a.Id != b.Id);
        }
    }
}
