using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace March10
{
    class Program
    {
         static void Main(string[] args)
            {
                printArray(topThreeWords("a A a b d d d d e e"));
                printArray(topThreeWords("a a a b c c d d d d e e e e e"));
                Console.ReadLine();
            }

            //Challenge 2<br>
            //Write a function that, given a string of<br>
            //text (possibly with punctuation and line-breaks), <br>
            //returns an array of the top-3 most occurring words, <br>
            //in descending order of the number of occurrences.<br>
            //Matches should be case-insensitive, and the<br>
            //words in the result should be lowercased.<br>
            //Ties may be broken arbitrarily.<br>
            //If a text contains fewer than three unique words, <br>
            //then either the top-2 or top-1 words should be returned, or an<br>
            //empty array if a text contains no words.<br>
            //Example:<br>
            //topThreeWords("a a a b c c d d d d e e e e e") => ['e', 'd', 'a']
            public static char[] topThreeWords(string input)
            {
                char[] result = new char[3];
                Regex rgx = new Regex("\\s+");
                string replacement = "";
                input = rgx.Replace(input, replacement);
                input = input.ToLower();                //case-insensitive 
                Console.WriteLine(input);

                //create a dictionary to hold non-duplicate chars as keys and the count as the value
                var d = new Dictionary<char, int>();
                //Filling in the dictionary
                foreach (char c in input)
                {
                    if (!d.ContainsKey(c))
                    {
                        d.Add(c, 0);
                    }
                    else
                    {
                        d[c] = d[c] + 1;
                    }
                }
                // I have the dictionary with no duplicate values and  the count of the characters.
                //d.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));

            //long way of finding top three max occuring keys
           
            for (int i = 0; i < 3; i++) {
                int maxValue = 0;   //not good I know, dummy placeholder values
                char maxKey = 'a'; //not good I know, dummy palceholder values
                foreach (KeyValuePair<char, int> kv in d)
                {
                    //Console.WriteLine("kv.Value > maxValue " + kv.Value + " " + maxValue);
                    if (kv.Value > maxValue)
                    {
                        maxValue = kv.Value;
                        maxKey = kv.Key;
                    }
                }
               // Console.WriteLine(maxKey);
                result[i] = maxKey;
                d.Remove(maxKey);
            }
            return result;
            }

        //This method prints the char array supplied to it.
        public static void printArray(char[] result)
        {
            foreach( char c in result)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        
    }
}
