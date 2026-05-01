//  编写一个方法 GetMax，接收两个 double 参数，返回较大的值。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        double num1;
        double num2;
        Console.WriteLine("请输入第一个双精度浮点数：");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("请输入第二个双精度浮点数：");
        num2 = double.Parse(Console.ReadLine());
        double max = GetMax(num1, num2);
        Console.WriteLine($"较大的值是: {max}");
    }

    public static double GetMax(double a, double b)
    {
        return (a > b) ? a : b;
    }
}