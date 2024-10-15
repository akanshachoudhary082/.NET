using System;

class Program
{
    public static void Main(String[] args)
    {
        int[] arr = { 23, 45, 12, 67, 45, 90 };

        int n = arr.Length;

        BubbleSort(arr,n);

        if(n >=2)
        {
            Console.WriteLine("Largest Second element:" + arr[n -2]);
        }
        else
        {
            Console.WriteLine("Not Largest ");
        }
    }

    static void BubbleSort(int[] arr,int n)
    {
        for(int i=0;i<n-1;i++)
        {
            for(int j=0;j<n - i -1;j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}