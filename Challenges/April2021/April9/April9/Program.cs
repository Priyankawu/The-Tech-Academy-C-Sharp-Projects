using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// WHAT I LEARNED IN THIS CHALLENGE
// When you do string[i], it gives you the ith char, not the ith word
// Use string.Split(), to get an array of words instead of the above
// When you do string.Length, it gives you the number of chars, not number of words
// Array. IndexOf(arr, item);
// static methods can be called as method() instead of object.method();

namespace April9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello world";
            string b = "This is a roundtable coding challenge.";
            string c = "";

            Console.WriteLine(hashtagGenerator(a));
            Console.WriteLine(hashtagGenerator(b));
            Console.WriteLine(hashtagGenerator(c));

            Console.WriteLine(hightestScoringWord(b));

            Console.Read();
            
        }

        //        Challenge 1
        //Your job is to create a hashtag generator.Here is what you need to know:
        //The input of your function will be a string.
        //It must start with a hashtag(#).
        //All words must have their first letter capitalized.
        //If the final result is longer than 140 chars it must return false.
        //If the input or the result is an empty string it must return false.
        
        public static bool hashtagGenerator(string input)
        {
            bool ans = false;
            //if input is empty or null, just return
            if (input.Length == 0 || input == null)
            {
                return ans;
            }
           
            char[] arr = new char[input.Length];
            arr[0] = Char.ToUpper(input[0]);    //capitalize first letter
            bool flag = false;
            int fill = 1;       //fill is the index to be filled in arr, i is index iterating thru input
           

           for(int i=1; i<input.Length; i++)
            {
                while (input[i] == ' ')        //next char needs to be capital
                {
                    i = i + 1;
                    flag = true;            //when out of this loop, you will be at the first char of word
                }
                if (flag)
                {                 
                    arr[fill] = Char.ToUpper(input[i]);  //first char of word, so capitalize
                    fill += 1;
                    flag = false;
                }
                else             //not the first char of word, so just copy
                {
                    arr[fill] = input[i];
                    fill += 1;
                }
            }
            input = String.Join("", arr);
            input = "#" + input;
            if (input.Length <= 140)
            {
                ans = true;
            }
           
            return ans;
        }

        //        Challenge 2
        //Given a string of words, you need to find the highest scoring word.
        //Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
        //You need to return the highest scoring word as a string.
        //If two words score the same, return the word that appears earliest in the original string.
        //All letters will be lowercase and all inputs will be valid.

        public static string hightestScoringWord(string input)    //lowercase and valid input
        {
            input = input.ToLower();
            char[] charArr = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x','y','z' };                

            //assign each letter a score
            //find score of a word
            string[] strArray = input.Split(' ');       //returns string array of individual words
            //print strArray
            
            //char[] inputArr = input.ToCharArray();
            int len = strArray.Length;      //number of words in input string
            int[] scoreMax = new int[len];
            for (int i=0; i<len; i++)        // iterate as many times as no. of words in input
            {
                //for each char in word, find score and add
                string word = strArray[i];      //each word from the input string
                int score = 1;                  //takes into account that every index has score of +1.

                
                for(int j=0; j<word.Length; j++)     //iterate for each char in the word
                {
                    char eachChar = word[j];
                    score = score + Array.IndexOf(charArr, eachChar);
                    Console.WriteLine("Score : " + score + " "+word);
                }   //found score of the word
                scoreMax[i] = score;    //store score in the same index of the strArray word 
                
            }
            //find the index of maximum score in scoreMax and return the word in that index of strArray 
            int index = Array.IndexOf(scoreMax, scoreMax.Max());
            string max_word = strArray[index];

            return max_word;

        }
    }
}
