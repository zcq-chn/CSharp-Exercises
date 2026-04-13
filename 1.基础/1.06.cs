//  编写程序交换两个整数变量的值（不使用第三个临时变量），并输出交换前后的值。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("交换前：a = {0}, b = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        //  元组交换
        // (a, b) = (b, a);

        Console.WriteLine("交换后：a = {0}, b = {1}", a, b);
    }
}