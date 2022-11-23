using static AlgorithmsAndSearches.UseAnagram;

namespace AlgorithmsAndSearches
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select option\n 1.Binary Search\n 2.InsertionSort \n 3.BubbleSort \n 4.Anagram");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadTextFile(@"D:\217.NetBatch\Algorithm_Programs\AlgorithmsAndSearches\binarysearch.txt");
                        binarySearch.BinarySearchOperation("We");
                        break;
                    case 2:
                        InsertionSort insertionSort = new InsertionSort();
                        int[] binaryarr = { 1, 2, 4, 5, 7, 9 };
                        insertionSort.Sort(binaryarr);
                        break;
                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        int[] arr= {5,67,23, 5, 7, 9 };
                        bubbleSort.Sort(arr);
                        break;
                    case 4:
                        Anagram check = new Anagram();
                        check.CheckAnagram("heart", "earth");
                        break;






                }

            }
        }
    }
}