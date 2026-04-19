//  将一个字符串中的所有空格去除，并输出处理前后的字符串。例如输入 "hello world" 输出 "helloworld"

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入一个字符串：");
        string input = Console.ReadLine();

        Console.WriteLine($"处理前的字符串：|{input}|");
        Console.WriteLine($"去掉字符串前后空格后的字符串：|{input.Trim()}|");
        Console.WriteLine($"去掉字符串前面空格后的字符串：|{input.TrimStart()}|");
        Console.WriteLine($"去掉字符串后面空格后的字符串：|{input.TrimEnd()}|");
    }
}