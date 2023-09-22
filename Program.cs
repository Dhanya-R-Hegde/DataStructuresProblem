namespace DataStructuresProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.BubbleSortArray();

            //int[] arr1 = { 4, 5, 3, 8, 1 };
            //MergeSort mergeSort = new MergeSort();
            //mergeSort.divide(arr1, 0, 4);
            //mergeSort.PrintArray(arr1);

            int[] arr2 = { 4, 5, 3, 8, 1 };
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.insertionSort(arr2);
            insertionSort.PrintArray(arr2 );
        }
    }
}
