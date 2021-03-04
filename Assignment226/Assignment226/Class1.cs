using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment226
{
    class Class1
    {

        public int doMath(int n)
        {
            int ans = n * 99;
            return ans;
        }
        //method overloading: same name method but differences
        public int doMath(decimal n)
        {
            decimal ans = n * 99;
            return (int)ans;
        }

        public int doMath(string s)
        {
            int n = Int32.Parse(s);
            int ans = n % 6;
            return ans;
        }
    }
}
