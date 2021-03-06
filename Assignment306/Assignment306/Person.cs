using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment306
{
    public abstract class Person        //can't instantiate this
    {
        public string firstName;
        public string lastName;

        public abstract void SayName();
    }
}
