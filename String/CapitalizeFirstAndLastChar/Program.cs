using System;
using System.Reflection.PortableExecutable;

class Program
{
    public static void Main(String[] args)
    {
        char c = 'f';

        if (c == 'a' || c == 'e' || c== 'i' || c == 'o' || c == 'u')
        {
            Console.WriteLine("voewl " + c);

        }else if(Char.IsLetter(c))
            {
            Console.WriteLine("consonant " + c);
        }
        else
        {
            Console.WriteLine("NOT A valid character");
        }

        
    }
}