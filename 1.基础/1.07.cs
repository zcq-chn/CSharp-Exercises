//  从控制台读取两个整数，输出它们的和、差、积、商和余数。需考虑除数为 0 的情况并给出友好提示。

using System;
class Program
{
    static void Main()
    {
        Console.Write("请输入第一个整数: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("请输入第二个整数: ");
        int num2 = int.Parse(Console.ReadLine());

        // 计算和、差、积
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;

        Console.WriteLine($"和: {sum}");
        Console.WriteLine($"差: {difference}");
        Console.WriteLine($"积: {product}");

        // 计算商和余数，考虑除数为0的情况
        if (num2 != 0)
        {
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine($"商: {quotient}");
            Console.WriteLine($"余数: {remainder}");
        }
        else
        {
            Console.WriteLine("除数不能为0，请重新输入第二个整数。");
        }
    }
}