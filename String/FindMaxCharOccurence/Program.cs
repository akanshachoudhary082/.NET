using System;

class Program
{
    public static void Main(String[] args)
    {
        String str = "Hello";

        char result = FindMax(str);

        Console.WriteLine(result);
    }

    static char FindMax(String str)
    {
        int[] freq = new int[256];
        int max = 0;
        char maxChar ='\0';
        for(int i=0;i<str.Length;i++)
        {
            freq[str[i]]++;
        }

        for(int i=0;i<str.Length;i++)
        {
            if (freq[str[i]] > max)
            {
                max = freq[str[i]];
                maxChar = str[i];
            }
        }

        return maxChar;
    }
     
}