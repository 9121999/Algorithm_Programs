using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class BinarySearch
    {
        string[] binaryArr;
        public void ReadTextFile(string filePath)
        {
            string words = File.ReadAllText(filePath);
            binaryArr = words.Split(",");
        }
        public void BinarySearchOperation(string input)
        {
            foreach (var word in binaryArr)
            {
                if (word.Equals(input))
                {
                    Console.WriteLine("Found the word in the list using binary serach");
                    return;
                }
            }
            Console.WriteLine("Search elementt is not available in list of words");
        }
    }
}




