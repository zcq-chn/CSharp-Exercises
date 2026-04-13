//  从控制台读取用户输入的名字，然后输出问候语：“你好，[用户输入的名字]！”。
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("请输入你的名字：");
        string? name = Console.ReadLine();
        Console.WriteLine("你好，{0}！", name);
    }
}