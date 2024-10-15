using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("ENTER THE STRING :");
        String str = Console.ReadLine();

        char[] s = str.ToCharArray();
        int length = 0;
        for(int i=0;i<str.Length;i++)
        {
            length++;
        }

        Console.WriteLine("lenght of Stirng :" + length);
    }
}