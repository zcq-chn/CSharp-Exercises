//  输入一个英文句子，统计其中字母 'a'（不区分大小写）出现的次数。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入一个英文句子：");
        string input = Console.ReadLine();

        int count = 0;
        foreach (char c in input)
        {
            if (char.ToLower(c) == 'a')
            {
                count++;
            }
        }

        Console.WriteLine($"字母 'a' 出现的次数：{count}");
    }
}