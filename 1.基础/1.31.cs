//  编写一个无返回值的方法 PrintWelcome，在方法内输出“欢迎学习 C# 方法！”，并在 Main 中调用它。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        PrintWelcome();
    }

    public static void PrintWelcome()
    {
        Console.WriteLine("欢迎学习 C# 方法！");
    }
}