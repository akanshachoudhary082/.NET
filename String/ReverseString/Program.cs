using System;

namespace ReverseString
{

    class Progrma
    {
        public static void Main(String[] args)
        {
            String str = "Hello";
            String rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            Console.WriteLine(rev);
        }
    }
}