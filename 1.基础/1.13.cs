//  输入一个年份，判断是否为闰年（普通闰年：能被4整除但不能被100整除；世纪闰年：能被400整除）。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.writelone("请输入一个年份：");
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine($"{year} 是闰年。");
        }
        else
        {
            Console.WriteLine($"{year} 不是闰年。");
        }
    }
}