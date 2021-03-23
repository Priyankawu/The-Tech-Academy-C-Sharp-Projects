using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment383
{
    public class Class1
    {
        // const keyword so this variable cannot be changed in the rest of the program.
        //public const string consty = "You cannot change this variable constant in the rest of the program. But I think you can always change it right here.";
        //trying to experiment with changing the const string.
     

        Console.WriteLine("constant ");
        consty += "Told you. It won't work.";

        //the keyword 'var' can be used only in local declaration e.g. here in this local method??
        public void myMethod()
        {
            var emp = new Employee("First", "Last", 3);
            

        }

        


        
    }
}
