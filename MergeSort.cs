using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProblems
{
    internal class MergeSort
    {   
        public void conquer(int[] arr, int si, int mid, int ei)
        {
            int []merged = new int[ei-si+1];
            int index1 = si;
            int index2 = mid + 1;
            int x = 0;

            while(index1 <= mid && index2 <= ei)
            {
                if (arr[index1] <= arr[index2])
                {
                    merged[x++] = arr[index1++];
                }
                else
                {
                    merged[x++] = arr[index2++];
                }
            }

            while(index1 <= mid)
            {
                merged[x++] = arr[index1++];
            }

            while (index2 <= ei)
            {
                merged[x++] = arr[index2++];
            }

            int j = si;
            for (int i = 0;  i < merged.Length; i++)
            {
                arr[j] = merged[i]; j++;
            }
        }
        public void divide(int[] arr, int si, int ei)
        {
            if (si >= ei)
            {
                return;
            }
            int mid = si + (ei - si) / 2;
            divide(arr, si, mid);
            divide(arr, mid + 1, ei);
            conquer(arr, si, mid, ei);


        }

        public void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
