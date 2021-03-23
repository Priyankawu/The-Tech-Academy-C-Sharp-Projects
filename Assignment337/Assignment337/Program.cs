using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment337
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee("Joe", "Sharma", 0));
            empList.Add(new Employee("Joe","Gupta",1));
            empList.Add(new Employee("Priyanka", "Agarwal",2));
            empList.Add(new Employee("Joe", "Arora",3));
            empList.Add(new Employee("Hirsh", "Royal",4));
            empList.Add(new Employee("Aaria", "Royal",5));
            empList.Add(new Employee("Eshvin", "Royal",6));
            empList.Add(new Employee("Priyanka", "Royal",7 ));
            empList.Add(new Employee("Sanjeev", "Royal",8 ));
            empList.Add(new Employee("Ashish", "Gupta",9 ));

            List<Employee> joes = empList.FindAll(x => x.firstName == "Joe");       //FindAll returns a list

            List<Employee> ids = empList.FindAll(x => x.Id > 5);

            foreach(Employee joe in joes)
            {
                Console.WriteLine("Confusion: "+joe.firstName);
            }
            foreach(Employee id in ids)
            {
                Console.WriteLine("Confusion: " + id.Id);
            }

            //lambda way of condensing code
            foreach (Employee joe in empList.FindAll(x => x.firstName == "Joe")) { 
                Console.WriteLine(joe.firstName);
            }

            foreach(Employee id5 in empList.FindAll(x => x.Id > 5))
            {
                Console.WriteLine(id5.Id);
            }

            // brute way of doing it
            //foreach(Employee joe in empList)
            //{
            //    if (joe.firstName == "Joe")
            //    {
            //        joes.Add(joe);
            //        Console.WriteLine(joe.firstName);
            //    }
            //}


          
            Console.ReadLine();




        }
    }
}
