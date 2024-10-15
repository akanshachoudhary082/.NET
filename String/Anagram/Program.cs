using System;

class Program
{
    public static void Main(String[] args)
    {
        String s1 = "Silent";
        String s2 = "Listen";

        s1 = s1.Replace(" ", " ").ToLower();
        s2 = s2.Replace(" ", " ").ToLower();

        char[] a = s1.ToCharArray();
        char[] b = s2.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        Console.WriteLine("Sorted s1" + new string(a));
        Console.WriteLine("Sorted s2" + new string(b));

        if (a.SequenceEqual(b))
        {
            Console.WriteLine(s1 + "AND" + s2 + " ARE ANAGRAM");
        }
        else
        {
            Console.WriteLine(s1 + "AND" + s2 + "NOT Ana");
        }
    }
}