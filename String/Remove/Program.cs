using System;
using System.Text.RegularExpressions;

namespace ReverseString
{

    class Program
    {
        public static void Main(String[] args)
        {
            //Remove brackets

            /*String str = "(Hello)";
            String s = Regex.Replace(str,"[(),{}]"," ");
            Console.WriteLine(s);*/

            //Remove AllCharAcceptAlpha

            /*String str = "@6680hgg!!iohpt";
            String s = Regex.Replace(str, "[^a-zA-Z]","");
            
            Console.WriteLine(s);*/

            //Remove  AllAphaAcceptSpecialCharacters

            /*String str = "@6680hgg!!iohpt";
            String s = Regex.Replace(str, "[a-zA-Z]", "");

            Console.WriteLine(s);*/

            //Remove  AllAcceptNumbers

            String str = "@6680hgg!!iohpt";
            String s = Regex.Replace(str, "[^0-9]", "");

            Console.WriteLine(s);


        }
    }
}