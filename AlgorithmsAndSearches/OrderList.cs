using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmsAndSearches.SortList;

namespace AlgorithmsAndSearches
{
    internal class OrderList
    {

        public void ReadTextFileSortList(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(",");
            SortingList<int> sortingList = new SortingList<int>();

            foreach (var data in words)
            {
                int result = Convert.ToInt32(data);
                sortingList.AddNode(result);
            }
            Console.WriteLine("Before sort");
            sortingList.Display();
            sortingList.SortedList();

            Console.WriteLine("After sort");
            sortingList.Display();
            
        }
    }
}


