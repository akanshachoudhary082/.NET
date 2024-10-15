using System;

class Program
{
    //public static void Main(String[] args)
    //{
    //    int[] arr = { 10, 5, 3, 8, 9 };
    //    Array.Sort(arr);
    //    int rev = 0;

    //    for(int i= arr.Length - 1;i >=0;i--)
    //    {
    //        Console.WriteLine(arr[i]);
    //    }

    //}



    public static void Main(String[] args)
    {
        int [] arr = { 10, 11, 12, 13, 14 };
        int n = arr.Length;
        int start = 0;
        int end = n - 1;

        reverseRecursive(arr, start, end);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i] + "");
        }

    }

    static void reverseRecursive(int[] arr, int start, int end)
    {

        if (start >= end)
            return;

        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        reverseRecursive(arr, start + 1, end - 1);
    }
}