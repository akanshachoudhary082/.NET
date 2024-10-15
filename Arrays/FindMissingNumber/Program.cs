

namespace FindMissingNumber
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 4, 5 };
            int n = arr.Length + 1;
            int totalSum = n * (n + 1) / 2;
            int arrSum = 0; 

            foreach(int num in arr)
            {
                arrSum = arrSum + num;
            }


            Console.WriteLine("print total :" + (totalSum - arrSum));
        }
    }
}