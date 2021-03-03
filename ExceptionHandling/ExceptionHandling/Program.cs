using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int> { 2, 4, 7, 5, 8, 9, 12, 45, 98 };
        Console.WriteLine("Please pick a number to divide the numbers in my list with.");
        float divisor = float.Parse(Console.ReadLine());              //user can type anything here - words, 0
        try
        {
            foreach (int n in numbers)
            {
                float ans = n / divisor;
                Console.WriteLine(n + " divided by " + divisor + " is " + ans);
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Please enter a proper number.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("The program has emerged out of try/catch block and continued on with program execution.");
            Console.ReadLine();
        }

    }
}

    
//tutorial code
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch(FormatException ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please write a proper number.");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally //executes always with or without any exception even if there is return before.
            //{
            //    Console.ReadLine();
            //}
            //Console.ReadLine();

//}

