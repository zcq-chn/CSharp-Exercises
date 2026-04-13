//  定义三个 double 类型的变量表示三门成绩，计算并输出平均分（保留两位小数）。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        double score1 = 85.5;
        double score2 = 90.0;
        double score3 = 95.5;

        double average = (score1 + score2 + score3) / 3;
        Console.WriteLine("平均分：{0:F2}", average);
    }
}