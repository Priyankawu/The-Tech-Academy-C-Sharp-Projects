using System;

namespace Math
{
    class Program
    {
        static void Main()
        {
            int a = 3;
            int b = 7;
            int sum = a + b;
            int diff = a - b;
            int multiply = a * b;
            float div = ((float)a) / ((float)b);
            Console.WriteLine("Addition:" + sum + "\n Subtraction: " + diff + "\n Multiply:" + multiply + "\n Divide: " + div);
            Console.Read();
        }
    }
}
