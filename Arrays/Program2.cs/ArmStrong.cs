using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.cs
{
     class Program1
    {
        public static void Main(String[] args)
        {
           
            int num = 153;
            int rem;
            int sum = 0;
            int temp = num;

            while(num !=0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }

            if(temp == sum)
            {
                Console.WriteLine("It is arm");
            }
            else
            {
                Console.WriteLine("not arm");
            }

        }

    }
}
