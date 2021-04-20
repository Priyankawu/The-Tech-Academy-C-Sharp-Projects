using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF6Console
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base() { }

        public DbSet<Student> Students { get; set; }
    }
}
