//  编写一个方法 GetMaxMin，接收一个整数数组，要求通过 out 参数返回数组中的最大值和最小值。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers;
        Console.WriteLine("请输入整数数组（用逗号分隔）：");
        string input = Console.ReadLine();
        numbers = Array.ConvertAll(input.Split(','), int.Parse);
        GetMaxMin(numbers, out int max, out int min);
        Console.WriteLine($"数组中的最大值是: {max}");
        Console.WriteLine($"数组中的最小值是: {min}");
    }

    public static void GetMaxMin(int[] arr, out int max, out int min)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("数组不能为空");
        }

        max = arr[0];
        min = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
    }
}