using System;

public class Stoog_Sort
{
	public Stoog_Sort()
	{
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 4, 6, 1, 3 };
            StoogeSort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(", ", arr));
        }

        static void StoogeSort(int[] arr, int i, int j)
        {
            if (arr[j] < arr[i])
            {
                Swap(arr, i, j);
            }
            if (j - i > 1)
            {
                int t = (j - i + 1) / 3;
                StoogeSort(arr, i, j - t);
                StoogeSort(arr, i + t, j);
                StoogeSort(arr, i, j - t);
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
}
