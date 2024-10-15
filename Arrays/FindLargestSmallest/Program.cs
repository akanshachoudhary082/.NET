using System;

namespace FindLargestSmallest
{
    class Program
    {
        public static void Main(String[] args)
        {

            int[] arr = { 12, 13, 14, 1, 34, 10 };
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("print min and max " + max + " " + min);
        }
    }
}