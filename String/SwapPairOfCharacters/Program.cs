using System;

namespace SwapPairOfCharacters
{
    class Program
    {
        public static void Main(String[] args)
        {
            String str = "abcdef";
            String s = " ";
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length - 1; i += 2)
            {
                char temp = ch[i];
                ch[i] = ch[i + 1];
                ch[i + 1] = temp;
            }

            // Convert the modified char array back to a string
            String swappedStr = new String(ch);

            // Print the swapped string
           Console.WriteLine("Swapped: " + swappedStr);

        }

    }

}