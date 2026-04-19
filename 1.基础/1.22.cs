//  声明一个 string 数组存储一周七天的中文名称，使用 foreach 循环输出每一天。
using System;
public class Program
{
    public static void Main(string[] args)
    {
        string[] days = ["星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日"];

        Console.WriteLine("一周七天的中文名称：");
        foreach (string day in days)
        {
            Console.WriteLine(day);
        }
    }
}