using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class InsertionSort
    {
        public void Sort(int[] binaryArr)
        {
            for (int i = 0; i < binaryArr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (binaryArr[i].CompareTo(binaryArr[j]) < 0)
                    {
                        int temp = binaryArr[j];
                        binaryArr[j] = binaryArr[i];
                        binaryArr[i] = temp;
                    }
                }
            }
            foreach (var data in binaryArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
