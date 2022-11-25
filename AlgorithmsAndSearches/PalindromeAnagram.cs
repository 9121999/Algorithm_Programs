using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    public class PalindromeAnagram
    {
        const int START_INDEX = 0, END_INDEX = 1000;
        int[] prime = new int[END_INDEX];
        int[] palindrome = new int[END_INDEX];
        int[] angram = new int[END_INDEX];
        public void PrimeNumber()
        {
            for (int i = 3; i < END_INDEX - 1; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    prime[i] = i;
                    Console.WriteLine("Prime No Is:" + prime[i]);
                }
            }
        }
        public void Palindrome()
        {
            for (int i = 10; i < END_INDEX - 1; i++)
            {
                int total = 0;
                if (prime[i] != 0)
                {
                    int num = prime[i];
                    while (num > 0)
                    {
                        int rem = num % 10;
                        total = total * 10 + rem;
                        num = num / 10;
                    }
                    if (total == prime[i])
                    {
                        palindrome[i] = prime[i];
                        Console.WriteLine("palindrome No Is:" + prime[i]);
                    }
                }
            }

        }
        public int Test(int check)
        {
            string num = check.ToString();
            char[] arr = num.ToCharArray();
            Array.Sort(arr);
            num = new string(arr);
            int actual = Convert.ToInt32(num);
            return actual;
        }
        public void AnagramCheck()
        {
            for (int i = 0; i < palindrome.Length - 1; i++)
            {
                for (int j = 0; j < prime.Length - 1; j++)
                {
                    if (palindrome[i] != 0 && prime[j] != 0)
                    {
                        if (Test(palindrome[i]).Equals(Test(prime[j])))
                        {
                            Console.WriteLine("Anagram No Is: " + palindrome[i]);
                        }
                    }
                }
            }
        }
    }
}


