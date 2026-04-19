//  反转一个字符串。例如输入 "hello"，输出 "olleh"

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入一个字符串：");
        string input = Console.ReadLine();

        Console.WriteLine($"反转后的字符串：{input.Reverse()}");
    }
}