using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProblems
{
    internal class InsertionSort
    {
        public void insertionSort(int[] arr) 
        {
            for(int i=1; i<arr.Length; i++)
            {
                int current = arr[i];
                int j=i-1;

                while(j>=0 && current < arr[j])
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = current;
            }
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
