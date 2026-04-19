//  定义一个 List<int> 集合，从控制台循环读取整数并添加到集合中，直到用户输入 -1 停止。最后输出集合中所有元素的平方值。

using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("请输入整数，输入 -1 停止：");
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == -1)
            {
                break;
            }
            numbers.Add(input);
        }
        Console.WriteLine("集合中所有元素的平方值：");
        foreach (int num in numbers)
        {
            Console.WriteLine($"{num} 的平方是 {num * num}");
        }

    }
}