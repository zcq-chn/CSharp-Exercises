//  编写方法 Multiply，利用方法重载实现：①接收两个整数返回积；②接收两个浮点数返回积；③接收三个整数返回积。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int intResult1 = Multiply(3, 4);
        Console.WriteLine($"两个整数的积: {intResult1}");

        double doubleResult = Multiply(2.5, 4.0);
        Console.WriteLine($"两个浮点数的积: {doubleResult}");

        int intResult2 = Multiply(2, 3, 4);
        Console.WriteLine($"三个整数的积: {intResult2}");
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
}