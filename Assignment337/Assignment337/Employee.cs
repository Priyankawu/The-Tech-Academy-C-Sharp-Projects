using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment337
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int Id;
        //constructor takes in parameters and sets the properties
        public Employee(string f, string l, int i)
        {
            firstName = f;
            lastName = l;
            Id = i;
        }
       

        
    }
}
