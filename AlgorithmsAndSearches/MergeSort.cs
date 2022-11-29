using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    public class MergeSort
    {
        public void Merge_Sort(int[] array, int lo, int hi)//lo-lower index, hi-higher index
        {
            if (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;

                Merge_Sort(array, lo, mid);
                Merge_Sort(array, mid + 1, hi);
                SortTwoArrays(array, lo, mid, hi);
            }
        }
        public void SortTwoArrays(int[] array, int lo, int mid, int hi)
        {
            int n1 = mid - lo + 1;
            int n2 = hi - mid;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            int i, j;
            for (i = 0; i < n1; i++)
            {
                leftArray[i] = array[lo + i];
            }
            for (j = 0; j < n2; j++)
            {
                rightArray[j] = array[mid + 1 + j];
            }
            i = 0; j = 0;
            int k = lo;
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = leftArray[i];
                i++; k++;
            }
            while (j < n2)
            {
                array[k] = rightArray[j];
                j++; k++;
            }
        }
        public void Display(int[] array)
        {
            foreach (var data in array)
                Console.WriteLine(data);
        }
    }
}
    
