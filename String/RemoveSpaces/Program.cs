using System;
using System.Text.RegularExpressions;



    class Program
    {
        public static void Main(String[] args)
        {
            String str = "        Hello World ";
        // String s = str.Replace(" ", " ");
        String s = Regex.Replace(str.Trim(), @"\s+", " ");
        //Putting it all together, the pattern @"\s+" means "match one or more whitespace
        Console.WriteLine(s);
        }
    }
