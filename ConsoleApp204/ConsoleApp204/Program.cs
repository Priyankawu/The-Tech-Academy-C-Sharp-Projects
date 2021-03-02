using System;
using System.Collections.Generic;


    class Program
    {
    //I didn't understand the assignment. Does string mean a sentence or a word? Is the user writing a paragraph and my array items are each sentence?
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a sentence.");
        string sentence = Console.ReadLine();
        string[] stArray = sentence.Split(' ');

        foreach (string word in stArray)
            Console.WriteLine(word);
        Console.Read();
    }
    }
