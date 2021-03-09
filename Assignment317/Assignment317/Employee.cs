using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment317
{
    public class Employee<T> { 

        public List<T> things = new List<T>();

        //prints items from teh list 'things'
        public void printAll()
        {
            foreach (T thing in things)
            {
                Console.WriteLine(thing);

            }
        }
    }
}
