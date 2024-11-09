// See https://aka.ms/new-console-template for more information
//
//
using System.Text.RegularExpressions;

namespace NonRepNumInDic{
    public class Program
    {

        //public static void Main(String[] args)
        //{
        //    Dictionary<int, int> mp = new Dictionary<int, int>();

        //    int[] arr = { 1, 3, 2, 4, 5,7,1, 2, 3 };

        //    foreach(int num in arr)
        //    {
        //        if (mp.ContainsKey(num))
        //        {
        //            mp[num] = mp[num] + 1;
        //        }
        //        else
        //        {
        //            mp[num] = 1;
        //        }
        //    }

        //    foreach(var pair in mp)
        //    {
        //        if(pair.Value > 1)
        //        {
        //            Console.WriteLine(pair.Key + " =" + pair.Value);
        //        }
        //    }
        //}

        //

        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 6 };

            var nonRepNum = arr
                            .GroupBy(num => num)
                            .Where(group => group.Count() == 1)
                            .Select(group => group.Key)
                            //.Select(group => group.Value);


            foreach(var num in nonRepNum)
            {
                Console.WriteLine(num);
            }
        }
    }
}
