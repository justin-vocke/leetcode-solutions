using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class QuickSort
    {
        // Function to perform the partition
        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1; // Index of smaller element

            for (int j = low; j < high; j++)
            {
                // If current element is smaller than or equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;

                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[high] (or pivot)
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }

        // The main function that implements QuickSort
        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // pi is partitioning index, arr[pi] is now at right place
                int pi = Partition(arr, low, high);

                // Recursively sort elements before partition and after partition
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }
    }
}
