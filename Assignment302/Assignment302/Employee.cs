using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment302
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name is " + firstName +" "+ lastName);

        }
    }
}
