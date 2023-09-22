using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProblems
{
    using System;

    internal class BubbleSort
    {

        public void BubbleSortArray()
        {
            Console.WriteLine("Enter the array");
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.Read());
            }
            Console.WriteLine("Array before sorting");
            PrintArray(arr);

            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array after sorting");
            PrintArray(arr);
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
