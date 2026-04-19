//  使用 string.Join 将数组 ["苹果", "香蕉", "橙子"] 拼接成逗号分隔的字符串 "苹果,香蕉,橙子"

using System;
public class Program
{
    public static void Main(string[] args)
    {
        string[] fruits = ["苹果", "香蕉", "橙子"];
        string result = string.Join(",", fruits);
        Console.WriteLine(result);
    }
}