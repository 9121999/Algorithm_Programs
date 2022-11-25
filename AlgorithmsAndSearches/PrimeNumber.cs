using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class PrimeNumber
    {
            public void PrimeRange(int minNum, int maxNum)
            {
                Console.Write("Pime Numbers between given range are:");
                for (int i = minNum; i <= maxNum; i++)
                {
                    if (i > 2)
                    {
                        int temp = i;
                        bool isPrime = true;
                        for (int j = 2; j < temp; j++)
                        {
                            if (temp % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime == true)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    else
                    {
                        if (i == 2)
                            Console.Write(i + " ");
                    }
                }
                Console.WriteLine("\n ");
            }
    }
}


