using System;

class Program
{
    public static void Main(String[] args)
    {
        String str = "Hello";

        
        char result =  FindFirstNRChar(str);

        Console.WriteLine(result);
    }

    static char FindFirstNRChar(String str)
    {
        int[] freq = new int[256];

        for(int i=0;i<str.Length;i++)
        {
            freq[str[i]]++;
        }

        for(int i=0;i<str.Length;i++)
        {
            if (freq[str[i]] == 1)
            {
                return str[i];
            }
        }
        return '_';
    }
}