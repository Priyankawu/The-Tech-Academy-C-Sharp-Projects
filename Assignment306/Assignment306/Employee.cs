using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment306
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name is " + firstName +" "+ lastName);

        }
        public void Quit()
        {
            Console.WriteLine("Enough, I am quitting this game!");
           
        }
    }
}
