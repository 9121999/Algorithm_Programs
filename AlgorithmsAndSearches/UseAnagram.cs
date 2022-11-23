using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class UseAnagram
    {
        public class Anagram
        {
            public void CheckAnagram(string inputstr1, string inputstr2)
            {
                string input1 = Test(inputstr1);
                string input2 = Test(inputstr2);
                if (input1.Equals(input2))
                    Console.WriteLine(" is an Anagram");
                else
                    Console.WriteLine(" is not an Anagram");
            }
            public string Test(string input)
            {
                char[] array = input.ToCharArray();
                Array.Sort(array);
                return new string(array);
            }
        }
    }
}

