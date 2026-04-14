//  将字符串 "123" 转换为整数，将整数 456 转换为字符串，并输出转换前后的类型。

using System;
class Program
{
    static void Main()
    {
        string strNumber = "123";
        int intNumber = int.Parse(strNumber);

        Console.WriteLine($"字符串 '{strNumber}' 转换为整数: {intNumber}，类型: {intNumber.GetType()}");

        int anotherInt = 456;
        string anotherStr = anotherInt.ToString();

        Console.WriteLine($"整数 {anotherInt} 转换为字符串: '{anotherStr}'，类型: {anotherStr.GetType()}");
    }
}