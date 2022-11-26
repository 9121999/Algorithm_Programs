using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    public class UnordredList
    {

        public void ReadALlTextFiles(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(",");
            LinkedListGeneric<string> linklist = new LinkedListGeneric<string>();
            foreach (var data in words)
            {
                linklist.AddLast(data);
            }
            Console.Write("Enter word to search : ");
            string check = Console.ReadLine();
            foreach (var data in words)
            {
                if (data.Equals(check))
                {
                    linklist.SearchAndDelete(data);
                    linklist.Display();
                    return;
                }

            }
            linklist.AddLast(check);
            linklist.Display();
           




        }
    }
}
