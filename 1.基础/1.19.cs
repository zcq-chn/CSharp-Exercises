//  输出九九乘法表（上三角或下三角形式均可）。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j, 2} x {i, -2} = {i * j, -3}");
            }
            Console.WriteLine();
        }
    }
}