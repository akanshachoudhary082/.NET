using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRepeatedFreq
{
    public class Program1
    {
        public static void Main(String[] args)
        {
            Dictionary<int, int> mp = new Dictionary<int, int>();

            int[] arr = { 1, 3, 4, 2, 1, 4, 3, 2 };

            foreach(int num in arr)
            {
                if(mp.ContainsKey(num))
                {
                    mp[num] = mp[num] + 1;
                }
                else
                {
                    mp[num] = 1;
                }
               
            }


            //foreach(var pair in mp)
            //{
            //    Console.WriteLine($"{pair.Key} =>{pair.Value}");
            //}

            // Convert to List and use ForEach
            mp.ToList().ForEach(pair => Console.WriteLine($"{pair.Key}: {pair.Value}"));



        }

    }
}
