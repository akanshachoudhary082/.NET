using System;
using System.Text.RegularExpressions;

namespace ReverseString
{

    class Program
    {
        public static void Main(String[] args)
        {
            String str = "HEEuullo";
            String s = Regex.Replace(str,"[aeiouAEIOU]", "");
            Console.WriteLine(s);
        }
    }
}