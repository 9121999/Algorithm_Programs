using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.DataStructurePrograms
{
    public class PalindromeChecker
    {
        Queue<string> palindrome;
        public void ReadAllTextFile(string filepath)
        {
            string line = File.ReadAllText(filepath);
            string[] words = line.Split(",");
            palindrome = new Queue<string>();
            foreach (var data in words)
            {
                palindrome.Enqueue(data);
            }
            foreach (var data in words)
            {
                Console.WriteLine("Word to check for palindrome is " + data);
                bool result = CheckPalindrome(data);
                if (result)
                {
                    Console.WriteLine("{0} is palindrome ", data);
                }
                else
                {
                    Console.WriteLine("{0} is  not a palindrome ", data);
                }
                palindrome.Dequeue();
            }
        }
        public bool CheckPalindrome(string check)
        {
            char[] array = check.ToCharArray();
            int j = array.Length - 1;
            int i = 0; ;
            while (i < j)
            {
                if (array[i].Equals(array[j]))
                {
                    i++;
                    j--;
                }
                else
                    return false;
            }
            return true;
        }
    }
}