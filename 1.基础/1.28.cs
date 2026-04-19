//  输入一个字符串，判断它是否是一个合法的电子邮件地址（简单规则：必须包含 @ 和 .，且 @ 在 . 之前）。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入一个字符串：");
        string input = Console.ReadLine();

        if (input.Contains('@') &&
            input.Contains('.') &&
            input.IndexOf('@') < input.LastIndexOf('.'))
        {
            Console.WriteLine("这是一个合法的电子邮件地址。");
        }
        else
        {
            Console.WriteLine("这不是一个合法的电子邮件地址。");
        }
    }
}