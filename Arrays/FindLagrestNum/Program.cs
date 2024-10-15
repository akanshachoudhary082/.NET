using System;

namespace FindLargestNum
{
    class Program
    {
        //public static void Main(String[] args)
        //{
        //    int[] arr = { 12, 45, 2, 78, 90 };

        //    int max = arr[0];

        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        if (arr[i] > max){

        //            max = arr[i];

        //    }

              
        //    }
        //    Console.WriteLine("print the max number" + max);
        //}


        public static void Main(String[] args)
        {
            int[] arr = { 12, 45, 2, 78, 90 };

            //Arrays.sort --- in java 

            Array.Sort(arr);
            int max = arr[arr.Length - 1];
            Console.WriteLine("print the max :" + max);
        }
    }
}

