//  编写一个方法 Add，接收两个整数参数，返回它们的和。调用并输出结果。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;

        Console.WriteLine("请输入第一个整数：");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("请输入第二个整数：");
        num2 = int.Parse(Console.ReadLine());
        int result = Add(num1, num2);
        Console.WriteLine($"两个数的和是: {result}");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}