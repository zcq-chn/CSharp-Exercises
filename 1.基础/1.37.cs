//  编写一个方法 TryParseInt，接收一个字符串，尝试将其转换为整数。如果成功返回 true 并通过 out 参数输出转换结果；失败则返回 false 并输出 0。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入一个字符串：");
        string input = Console.ReadLine();
        if (TryParseInt(input, out int result))
        {
            Console.WriteLine($"转换成功，结果是: {result}");
        }
        else
        {
            Console.WriteLine("转换失败，结果是: 0");
        }
    }

    public static bool TryParseInt(string str, out int number)
    {
        return int.TryParse(str, out number);
    }
}