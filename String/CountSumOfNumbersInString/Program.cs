using System;

class Program
{
    public static void Main(String[] args)
    {
        String s= "23gh5lsdkl7kjkl7";
        char[] str = s.ToCharArray();
        int sum = 0;
        for(int i=0;i<str.Length;i++)
        {
            if (str[i] >='0' && str[i] <= '9')
            {
                sum = sum + str[i] - '0';
            }
           
        }

        Console.WriteLine(sum);
    }
}