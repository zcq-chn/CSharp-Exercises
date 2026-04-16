//  使用 switch 语句根据用户输入的 1~7 数字输出对应的星期几英文名称（Monday~Sunday）。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入一个数字（1-7）：");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("输入无效，请输入1-7之间的数字。");
                break;
        }
    }
}