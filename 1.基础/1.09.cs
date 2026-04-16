//  定义一个 DateTime 类型的变量表示当前日期时间，分别输出：当前日期、当前时间、明天的日期。

using System;
public class Program
{
    public static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine($"当前日期: {now.ToLongDateString()}");
        Console.WriteLine($"当前时间: {now.ToLongTimeString()}");

        DateTime tomorrow = now.AddDays(1);
        Console.WriteLine($"明天的日期: {tomorrow.ToLongDateString()}");
    }
}