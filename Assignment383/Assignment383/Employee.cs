using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment383
{
    class Employee
    {
        //Chaining constructors
        public Employee(string fname, string lname, int id) : this(fname,lname,id,10000)
        {
            
        }
        public Employee(string fname, string lname, int id, int salary)
        {
            firstName = fname;
            lastName = lname;
            Id = id;
            Salary = salary;
        }
        public string firstName;
        public string lastName;
        public int Id;
        public int Salary;
    }
}
