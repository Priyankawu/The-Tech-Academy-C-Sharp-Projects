using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sentenceSort("a || b in it");
            string before = " Hello my name is Forest and I love love love to code";
            before = " Hello my name my love my my Forest is to code love love I is";
            Console.WriteLine(before);
            Console.WriteLine("THE SORTED SENTENCE IS: \n "+sentenceSort(before));
            Console.Read();
        }

        public static string sentenceSort(string input)
        {
            //todo: get rid of punctuations
            //split string into two strings - one with lowercase starting words, other with uppercase starting words
            string lower = null;
            string upper = "";
            //break string to string array
            string [] strArray = input.Split(' ');
            for(int i = 0; i<strArray.Length; i++)
            {
                string word = strArray[i];
                //char c = words[i];
                //Console.WriteLine("just a char " + c);
                //Console.WriteLine(c.GetType());
                if (word.ToLower()== word)         //lower case start
                {
                    lower = lower + " "+word;
                   
                }
                else
                {
                    upper = upper + " " + word;
                }
            }
            //remove the white space in beginning or end
            lower = lower.Trim();
            upper = upper.Trim();
            //sort "lower" in ascending order
            lower = ascending(lower);
            upper = descending(upper);

            return lower + " "+upper;
        }

        public static string ascending(string lower)
        {
            if(lower.Length <= 1)       //return empty or one word strings
            {
                return lower;
            }
            string[] word1 = lower.Split(' ');
            int first = 0;
            int smallestIndex = -1;
            List<int> indices = new List<int>();
                        
            for (int i = 0; i < word1.Length - 1; i++)
            {
                char[] current = word1[i].ToCharArray();
                char smallest = current[first];
                indices.Clear();
                smallestIndex = i;

                for (int j = i + 1; j < word1.Length; j++)
                {
                    char[] next = word1[j].ToCharArray();
                    if (next[first] < smallest)
                    {
                        int count = indices.Count;
                        if (count == 0)
                        {
                            indices.Add(j);
                        }
                        else if ((next[first] == (word1[indices[indices.Count-1]].ToCharArray())[first]))      //ith item found again
                        {
                            indices.Add(j);
                        }
                        else
                        {
                            indices.Clear();
                            indices.Add(j);
                        }
                        smallest = next[first];
                        smallestIndex = j;
                    }
                  
                   
                }

                if(indices.Count > 0)           //found something smaller than the ith item
                {
                    for(int z = 0; z<indices.Count; z++)
                    {
                        if (smallest == current[first])     //if 
                        {    //replace from i+1, 
                            i = i + 1;
                        }
                            string temp1 = word1[i];
                            word1[i] = word1[indices[z]];
                            word1[indices[z]] = temp1;
                    }
                   
                }

                lower = String.Join(" ", word1);         //joins the parameter string[] into string with space between words
                //Console.WriteLine("Iterations:: " + lower);
            }
            lower = String.Join(" ", word1);         //joins the parameter string[] into string with space between words
            //Console.WriteLine("Lower sorted is: " + lower);
            return lower;
        }

        public static string descending(string lower)
        {
            if (lower.Length <= 1)       //return empty or one word strings
            {
                return lower;
            }
            string[] word1 = lower.Split(' ');
            int first = 0;
            int biggestIndex = -1;
            List<int> indices = new List<int>();


            for (int i = 0; i < word1.Length - 1; i++)
            {
                char[] current = word1[i].ToCharArray();
                char biggest = current[first];
                indices.Clear();
                biggestIndex = i;

                for (int j = i + 1; j < word1.Length; j++)
                {
                    char[] next = word1[j].ToCharArray();
                    if (next[first] > biggest)
                    {
                        //biggest = next[first];
                        //biggestIndex = j;
                        int count = indices.Count;
                        if (count == 0)
                        {
                            indices.Add(j);
                        }
                        else if ((next[first] == (word1[indices[indices.Count - 1]].ToCharArray())[first]))      //ith item found again
                        {
                            indices.Add(j);
                        }
                        else
                        {
                            indices.Clear();
                            indices.Add(j);
                        }
                        biggest = next[first];
                        biggestIndex = j;
                    }


                }

                if (indices.Count > 0)           //found something smaller than the ith item
                {
                    for (int z = 0; z < indices.Count; z++)
                    {
                        if (biggest == current[first])     //if 
                        {    //replace from i+1, 
                            i = i + 1;
                        }
                        string temp1 = word1[i];
                        word1[i] = word1[indices[z]];
                        word1[indices[z]] = temp1;
                    }

                }

                lower = String.Join(" ", word1);         //joins the parameter string[] into string with space between words
                //Console.WriteLine("Iterations:: " + lower);
            }
            lower = String.Join(" ", word1);         //joins the parameter string[] into string with space between words
            //Console.WriteLine("Lower sorted is: " + lower);
            return lower;
        }
       
    }
}
