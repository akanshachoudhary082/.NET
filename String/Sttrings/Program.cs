using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttrings
{
    class Program
    {

        public static void Main(String[] args)
        {
            String str = "Hello";
            FreqString(str);
        }

        static void FreqString(String str)
        {
            int[] freq = new int[256];
            
            for(int i=0;i<str.Length;i++)
            {
                freq[str[i]]++;
            }

            for(int i=0; i<freq.Length;i++)
            {
                if (freq[i] >0)
                {
                    Console.WriteLine((char)i + ":" + freq[i]);
                }
              
            }
        }
    }
}
