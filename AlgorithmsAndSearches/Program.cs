using DataStructureAlgorithm.DataStructurePrograms;
using System;
using static AlgorithmsAndSearches.UseAnagram;
using static AlgorithmsAndSearches.UserInput;

namespace AlgorithmsAndSearches
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select option\n 1.Binary Search\n 2.InsertionSort \n 3.BubbleSort \n 4.Anagram \n 5.UserInput \n 6.Generics \n 7.PrimeRange \n 8.PalindromeAndAnagram \n 9.UnOrderList \n 10.BalanceParenthesis \n 11.OrderList \n 12.BankCashCounter \n 13.Merge Array \n 14.PalindromeCheker");
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
                        int[] arr = { 5, 67, 23, 5, 7, 9 };
                        bubbleSort.Sort(arr);
                        break;
                    case 4:
                        Anagram check = new Anagram();
                        check.CheckAnagram("heart", "earth");
                        break;
                    case 5:
                        MessageDemonstration replace = new MessageDemonstration();
                        replace.ReplaceString();
                        break;
                    case 6:
                        LinkedListGeneric<string> linkedListGeneric = new LinkedListGeneric<string>();
                        linkedListGeneric.AddLast("Prerana");
                        linkedListGeneric.Display();
                        break;
                    case 7:
                        PrimeNumber range = new PrimeNumber();
                        range.PrimeRange(0, 100);
                        break;
                    case 8:
                        PalindromeAnagram list = new PalindromeAnagram();
                        list.PrimeNumber();
                        list.Palindrome();
                        list.AnagramCheck();
                        break;
                    case 9:
                        UnordredList unordredList = new UnordredList();
                        unordredList.ReadALlTextFiles(@"D:\217.NetBatch\Algorithm_Programs\AlgorithmsAndSearches\binarysearch.txt");
                        break;
                    case 10:
                        BalanceParenthisis balanceParenthisis = new BalanceParenthisis();
                        balanceParenthisis.Balanced(@"D:\217.NetBatch\Algorithm_Programs\AlgorithmsAndSearches\Number.txt");
                        break;
                    case 11:
                        OrderList order = new OrderList();
                        order.ReadTextFileSortList(@"D:\217.NetBatch\Algorithm_Programs\AlgorithmsAndSearches\Order.txt");
                        break;
                    case 12:
                        AtmBalance atmBalance = new AtmBalance();
                        atmBalance.ATMSYSTEM();
                        break;
                    case 13:
                        int[] array = { 2, 5, 6, 8 ,7,9 ,9};
                        int[] array2 = { 4, 8, 2, 9, 4 ,6,0,6};
                        MergeSort mergeSort = new MergeSort();
                        Console.WriteLine("Array Before Sorting: ");
                        mergeSort.Display(array);
                        mergeSort.Merge_Sort( array, 0,  array.Length - 1);
                        Console.WriteLine("Array after Sorting: ");
                        mergeSort.Display(array);
                        break;
                    case 14:
                        PalindromeChecker palindromeChecker = new PalindromeChecker();
                        palindromeChecker.ReadAllTextFile(@"D:\217.NetBatch\Algorithm_Programs\AlgorithmsAndSearches\PalindromeString.txt");
                        break;
                    

                }
            }
        }

    }

}
