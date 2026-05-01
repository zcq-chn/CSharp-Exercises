//  编写一个方法 Swap，交换两个整数变量的值，要求使用 ref 参数。在主函数中调用并观察结果。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int x = 5;
        int y = 10;

        Console.WriteLine($"交换前: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"交换后: x = {x}, y = {y}");
    }

    public static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}