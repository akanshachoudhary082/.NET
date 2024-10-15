using System.Collections.Generic;

class Program
{

    public static void Main(String[] args)
    {
        int[] arr = { 10, 20, 20, 30, 30, 40, 40, 50, 50, 60 };
        int n = arr.Length;
        SortedSet<int> sortedSet = new SortedSet<int>(arr);

        foreach(var item in sortedSet)
        {
            Console.WriteLine(item);
        }
    }
    

}