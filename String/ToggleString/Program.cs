using System;

class Program
{
    public static void Main(string[] args)
    {
        string s = "PrePInsta";
        string s1 = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                s1 += char.ToLower(s[i]);
            }
            else
            {
                s1 += char.ToUpper(s[i]);
            }
        }

        Console.WriteLine("Toggle string is: " + s1);
    }
}
