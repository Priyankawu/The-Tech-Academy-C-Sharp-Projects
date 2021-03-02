using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        //can create list with any datatype
        // List<int> intList = new List<int>;
        //intList.Add(4);
        // intList.Add(10);
        // intList.Remove(10);

        string[] stringA = new string[] {"Hello","How", "are", "you", "names","Priyanka", "Sanjeev" };
        Console.WriteLine("Please select an index from 0-6 of the Array to see the string at that index");

        int index = Convert.ToInt32(Console.ReadLine());
        while(index>6 || index < 0)
        {
            Console.WriteLine("This index does not exist. Please select an index between 0-6");
            index = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(stringA[index]);

        int[] intA = {5, 6, 7, 87, 3, 100, 569 };
        Console.WriteLine("Please select an index from 0-6 of the Array to see the integer at that index");
        index = Convert.ToInt32(Console.ReadLine());
        while (index > 6 || index < 0)
        {
            Console.WriteLine("This index does not exist. Please select an index between 0-6");
            index = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(intA[index]);

        List<string> stringList = new List<string> { "one", "two", "three", "four", "five", "hundred", "last" };
        Console.WriteLine("Please select an index from 0-6 to see the string at that index from the list");
        index = Convert.ToInt32(Console.ReadLine());
        while (index > 6 || index < 0)
        {
            Console.WriteLine("This index does not exist. Please select an index between 0-6");
            index = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(stringList[index]);
        Console.ReadLine();

        //byte[] byteArray = new byte[5000];
        //List<string> stringList = new List<string>;

        //int[] numArray = new int[5]; //need to specify the length
        //numArray[0] = 6;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //can add more, don't need to declare length

        //int[] numArray2 = { 5,2,10,200,5000,600,2300 };
        //numArray2[5] = 650;
        //Console.WriteLine(numArray1[3]);
        //Console.Read();
       }
    }

