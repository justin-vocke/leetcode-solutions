using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Sorting
    {
        public void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                // Sort first and second halves
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        public void Merge(int[] arr, int l, int m, int r)
        {
            // 1. Find sizes of two subarrays to be merged
            int leftSize = m - l + 1;
            int rightSize = r - m;

            // 2. create temp arrays
            int[] leftTempArr = new int[leftSize];
            int[] rightTempArr = new int[rightSize];

            // 3. Copy Data to temp arrays
            Array.Copy(arr, l, leftTempArr, 0, leftSize);
            Array.Copy(arr, m + 1, rightTempArr, 0, rightSize);

            // 4. Merge the temp arrays
            int i = 0, j = 0, k = l;
            while (i < leftSize && j < rightSize)
            {
                if (leftTempArr[i] <= rightTempArr[j])
                {
                    arr[k] = leftTempArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightTempArr[j];
                    j++;
                }
                k++;
            }

            //5. Copy remaining elements of leftTempArr if any
            while (i < leftSize)
            {
                arr[k] = leftTempArr[i];
                i++;
                k++;
            }

            //6. Copy remaining elements of rightTempArr if any
            while (j < rightSize)
            {
                arr[k] = rightTempArr[j];
                j++;
                k++;
            }

        }
    }
}
