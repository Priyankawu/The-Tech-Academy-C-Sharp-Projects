using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a dbContext and add student to it. 
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Priyanka Thakan" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
