//  计算 1 到 100 之间所有整数的和（包括 1 和 100），使用 while 循环实现。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int i = 1;

        while (i <= 100)
        {
            sum += i;
            i++;
        }

        Console.WriteLine($"1 到 100 之间所有整数的和是: {sum}");
    }
}