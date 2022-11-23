namespace AlgorithmsAndSearches
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select option\n 1.Binary Search\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadTextFile(@"D:\217.NetBatch\Algorithm_Programs\AlgorithmsAndSearches\binarysearch.txt");
                        binarySearch.BinarySearchOperation("We");
                        break;


                }

            }
        }
    }
}