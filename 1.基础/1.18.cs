//  使用 do-while 循环实现：不断提示用户输入一个正数，直到输入的值大于 0 为止，最后输出该值。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int number;

        do
        {
            Console.Write("请输入一个正数：");
            number = int.Parse(Console.ReadLine());
        } while (number <= 0);

        Console.WriteLine($"输入的正数是：{number}");
    }
}