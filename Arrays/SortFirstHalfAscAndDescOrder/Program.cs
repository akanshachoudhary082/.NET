using System;

class Program
{
    public static void Main(String[] args)
    {
        int[] arr = { 23, 1, 5, 3, 8, 90, 34, 56, 76,10 };

        int n = arr.Length;
        Array.Sort(arr);
        PrintInOrder(arr, n);

        
    }

    static void PrintInOrder(int[] arr,int n)
    {
        for(int i=0;i<n/2;i++)
        {
            Console.WriteLine("print ain asc" + arr[i]);
        }


        for(int i=n-1;i>=n/2;i--)
        {
            Console.WriteLine("print in desc" + arr[i]);
        }
    }
}