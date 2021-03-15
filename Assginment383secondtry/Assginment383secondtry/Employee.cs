using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment383secondtry
{
    class Employee
    {
        //chaining two constructors together
        public Employee(string fName, string lName, int id) : this(fName, lName, id, 10000)
        {

        }
        public Employee(string fName, string lName, int id, int salary)
        {
            firstName = fName;
            lastName = lName;
            Id = id;
            Salary = salary;
        }

        public string firstName;
        public string lastName;
        public int Id;
        public int Salary;

        public override string ToString()
        {
            return (firstName + " " + lastName + " ");
        }
    }
}
