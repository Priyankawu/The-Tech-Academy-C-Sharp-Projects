using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for(int i =0; i < testScores.Length; i++)
        //{
        //    if(testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //    string[] names = {"Priyanka", "Sanjeev", "Hirsh", "Aaria", "Eshvin" };

        //    for(int j=0; j<names.Length; j++)
        //    {

        //        Console.WriteLine("The name is: "+names[j]);

        //    }
        //Console.Read();

        List<int> testScores = new List<int>();
        testScores.Add(98);
        testScores.Add(99);
        testScores.Add(100);

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                Console.WriteLine("Passing test score: " + score);
            }
        }
        Console.Read();
    }
    }

