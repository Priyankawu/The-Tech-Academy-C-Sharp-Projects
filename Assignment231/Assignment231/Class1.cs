using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment231
{
    class Class1
    {

        //method with out parameter
        public void method1(int user_n, out int a)
        {
            a =  user_n / 2;
          
        }

        //overload a method

        public int add(int a, int b)
        {
            return a + b;
        }
        public string add(string a, string b)
        {
            return a + b;
        }
    }
}
