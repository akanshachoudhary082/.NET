using System;

class Program
{
    public static void Main(String[] args)
    {
        String[] str = { "Today", "is", "Monday" };
        String rev = "";

        for(int i=0;i<str.Length;i++)
        {
            String word = str[i];
            String revWord = "";

            for (int j = word.Length - 1; j >= 0;j--)
            {
                revWord = revWord + word[j];
            }

            rev = rev + revWord;

            if (i != str.Length - 1)
            {
                rev = rev + " ";
            }
        }
        Console.WriteLine(rev);
        
    }
}