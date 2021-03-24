using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2021
{
    class Challenges
    {


        //List<string> sList = new List<string>();    //constructor
        public List<int> toNumArray(List<string> sList)
        {
            List<int> intList = new List<int>();
            foreach (string s in sList)
            {
                int i = Convert.ToInt32(s);
                intList.Add(i);
                Console.WriteLine(i);
            }
            
            return intList;
        }
    }
}
