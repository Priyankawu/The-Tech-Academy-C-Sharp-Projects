using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ClassContext())
            {
                var stud = new Student() { StudentName = "Priyanka" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
