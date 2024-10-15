using System;

class Program
{
    public static void Main(String[] args )
    {
        int[] arr = { 12, 34, 2, 6, 4, 8, 60 };
        int n = arr.Length;
        SortElement(arr, n);
    }

    static void SortElement(int[] arr,int n)
    {
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if (arr[i]> arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        foreach(int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}