using System;

namespace CountNonRepeatingNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 40, 50, 20, 10, 20, 30, 10 };
            int n = arr.Length;
            Array.Sort(arr);  // Sort the array
            CountFreq(arr, n);  // Call method to count frequencies
        }

        static void CountFreq(int[] arr, int n)
        {
            bool[] visited = new bool[n];
            Array.Fill(visited, false);  // Initialize all elements as false

            for (int i = 0; i < n; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }

                if (count == 1)
                {
                    Console.WriteLine("Print the non-repeating number: " + arr[i]);
                }
            }
        }
    }
}
