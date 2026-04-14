//  让用户输入圆的半径（double 类型），计算并输出圆的周长和面积（使用 Math.PI）

using System;
class Program
{
    static void Main()
    {
        Console.Write("请输入圆的半径: ");
        double radius;
        while (!double.TryParse(Console.ReadLine(), out radius))
        {
            Console.Write("输入无效，请输入一个有效的数字: ");
        }

        double circumference = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"圆的周长: {circumference}");
        Console.WriteLine($"圆的面积: {area}");
    }
}