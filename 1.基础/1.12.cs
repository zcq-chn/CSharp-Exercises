//  输入三个整数，找出其中的最大值并输出。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入三个整数：");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.TryParse(Console.ReadLine());

        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine($"三个整数中最大的数是: {max}");
    }
}