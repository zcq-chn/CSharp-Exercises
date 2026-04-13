//  声明一个 bool 变量表示是否已婚，一个 char 变量表示血型，一个 decimal 变量表示工资，并将它们分别输出到一行。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        bool isMarried = false;
        char bloodType = 'B';
        decimal salary = 5000.00m;

        Console.WriteLine("已婚：{0}，血型：{1}，工资：{2}", isMarried, bloodType, salary);
    }
}