using System;

class Custom
{
    static void BuildMaxHeap(int[] arr, int n, int i)
    {
        int largest = i; // Initialize largest as root
        int left = 2 * i + 1; // left child
        int right = 2 * i + 2; // right child

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            Swap(arr, i, largest); 

            BuildMaxHeap(arr, n, largest);
        }
    }

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            BuildMaxHeap(arr, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            Swap(arr, 0, i);

            BuildMaxHeap(arr, i, 0);
        }
    }

    static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Original array:");
        PrintArray(arr);

        HeapSort(arr);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }
}
