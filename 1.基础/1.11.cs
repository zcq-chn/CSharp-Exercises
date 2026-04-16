//  输入一个整数，判断它是奇数还是偶数，输出结果。

using System;
using System.Reflection.Metadata.Ecma335;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is an even number.");
        }
        else
        {
            Console.WriteLine($"{num} is an odd number.");
        }
    }
}