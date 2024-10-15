using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    public static void Main(String[] args)
    {
        int[] arr = { 23, 45, 67 };
        int sum = 0;
        for(int i=0;i<arr.Length;i++)
        {
             sum = sum + arr[i];
        }

        Console.WriteLine(sum);
    }
}