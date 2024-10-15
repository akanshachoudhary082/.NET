using System;

class Program
{
    public static void Main(String[] args)
    {
        String str = "madam";
        String rev = "";
        int n = str.Length;

        for(int i=n - 1;i>=0;i--)
        {
            rev = rev + str[i];
        }

        if (str.SequenceEqual(rev))
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("not palindrome");
        }
    }
}