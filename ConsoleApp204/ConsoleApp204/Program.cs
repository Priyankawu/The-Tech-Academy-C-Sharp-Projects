using System;
using System.Collections.Generic;


    class Program
    {
    //I didn't understand the assignment. Does string mean a sentence or a word? Is the user writing a paragraph and my array items are each sentence?
    static void Main(string[] args)
    {
         Console.WriteLine("----------------- Assignment 1 -------------------");
        string[] stArray1 = {"First","Second","Third","Fourth","Fifth" };
        Console.WriteLine("Please enter some text.");
        string text = Console.ReadLine();
        for(int i=0; i<stArray1.Length; i++)
        {
            //string addon = stArray1[i] + text;
            //stArray1[i] = addon;
            stArray1[i] = stArray1[i] + text;
        }
        foreach (string word in stArray1)
        {
            Console.WriteLine(word);
        }

        //assignment 2
         Console.WriteLine("----------------- Assignment 2 -------------------");
        //this is an infinite loop
        int j = 0;
        while (true)
        {
            if (j >= 5)
                break;
            Console.WriteLine("Stay stuck");
            j++;
        }
        
        //assignment 3
         Console.WriteLine("----------------- Assignment 3 -------------------");
        int k = 0;
        while (k < 9)
        {
            Console.WriteLine("I will stop when k is 9. Right now, it is " + k);
            k++;
        }
        for (int n = -10; n <= -5; n++)
        {
            Console.WriteLine("I will stop when n is <= -5. Right now, it is " + n);
        }
        //assignment 4

         Console.WriteLine("----------------- Assignment 4 -------------------");
        List<string> stList = new List<string>{"First","Second","Third","Fourth","Fifth" };
        Console.WriteLine("Please type the text you would like to search for.");
        string match = Console.ReadLine();
        bool found = false;
        for(int i=0; i < stList.Count; i++)
        {
            if(stList[i] == match)
            {
                Console.WriteLine("Found the matching text at index: " + i);
                found = true;
                break;
            }
        }
        if (found == false)
        {
            Console.WriteLine("Your input is not on the list");
        }
        //assignment 5
        Console.WriteLine("----------------- Assignment 5 -------------------");
        List<string> stList1 = new List<string> {"First","Second","Third","Fourth","Fifth","Second" };
        Console.WriteLine("Assignment 5: Please enter a text so I can search my list for it.");
        string match1 = Console.ReadLine();

        bool found1 = false;
        bool found2 = false;
        int index1 = 0;
        int index2 = 0;
        
        for (int i = 0; i < stList1.Count; i++)
        {
            if (stList1[i] == match1)
            {
                //if (found1 == true)
                //{
                    //found2 = true;
                   // index2 = i;
                    Console.WriteLine("Your search word : '" + match1+"' is present at index "+  i);
                    //break;
                //}
                    found1 = true;
               // index1 = i;
                
            }
        }
        if (found1 == false)
        {
            Console.WriteLine("Your input is not on the list");
        }

        //assignment 6 
        Console.WriteLine("----------------- Assignment 6 -------------------");

        List<string> stList6 = new List<string>{ "First", "Second", "Third", "Fourth", "Fifth", "Second" };
        List<string> secondList = new List<string>();
        foreach(string word6 in stList6){
            if(secondList.Contains(word6)){
                Console.WriteLine("This string " + word6 + " has appeared in the list before.");
            }
            else{
                 Console.WriteLine("This string " + word6 + " has not appeared in the list yet.");
            }
            secondList.Add(word6);
        }
        Console.Read();
        
    }
    }
