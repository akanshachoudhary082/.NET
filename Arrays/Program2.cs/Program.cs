using System;

namespace AllArraysProgram
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = { 10, 30, 30, 20, 10, 20, 50, 10 };
            int n = arr.Length;

            CountRepeatedFreq(arr, n);
        }

         static void CountRepeatedFreq(int[] arr, int n)
        {
            bool[] visited = new bool[n];

            Array.Fill(visited, false);

            for(int i=0;i<n;i++)
            {
                if (visited[i] == true)
                {
                    continue;
                }

                int count = 1;

                for(int j=i+1;j<n;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count = count + 1;
                    }
                }

                if(count != 1)
                {
                    Console.WriteLine("print the number:" + arr[i] + " " + "frequency:" + count);
                }

            }
        }

        
    }
}