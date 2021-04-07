using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace March26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(rearrange("rkqodlw", "world"));
            Console.WriteLine(rearrange("huhbkiehlebiuop", "Hello"));
            Console.WriteLine(rearrange("katas", "steak"));

            //Console.WriteLine("Please create a password.");
            //string password = Console.ReadLine();
            string password = "ABdfkj44";

            Console.WriteLine(validate(password));
            
            Console.Read();
        }
        //Challenge 1
        //Write a function that takes in 2 strings.If at least a portion of
        //the first string can be rearranged to form the second string, return true.
        //Otherwise, return false. No punctuation or numbers will be used as input.
        public static Boolean rearrange(string a, string b)
        {
            a = a.ToLower();
            b = b.ToLower();
            for (int i = 0; i<b.Length; i++)
            {
                if (!a.Contains(b[i]))
                {
                    return false;
                }
                a.Replace(a[i], ' ');    //Do this for "dlksjfd" he
            }

            return true;
        }

            //        Challenge 2  
            //You will need to write a regex(regular expression) that will validate a password to make sure it meets the following criteria:
            //At least six characters long
            //contains a lowercase letter
            //contains an uppercase letter
            //contains a number
            //Valid passwords will only be alphanumeric characters.We have talked about regular expressions at previous roundtables, 
            //but they can be a little tricky.Here are some handy resources to help you out.
            //https://www.computerhope.com/jargon/r/regex.htm
            //https://regex101.com/
            //https://www.rexegg.com/regex-quickstart.html

            //Example(in JavaScript) :
            //function validate(password)
            //        {
            //            return / (put answer here)/.test(password);
            //        }

        public static string validate(string password)
        {
            string message = "Your password must be atleast 6 characters long, contain a lowercase letter, an uppercase letter and a number.";
            //if (password.Length < 6)
            //{
            //    return message;
            //}
            string pattern = ("/[a-z+A-Z+0-9+]/");
                //@"([a-zA-Z0-9])";
            Regex rgx = new Regex(pattern);
            bool valid = Regex.IsMatch(password, pattern);
            if (!valid)
            {
                return message;
            }
            else
            {
                return ("Good password");
            }
            
        }

    }
}
