//  输入 5 个整数存入数组，求数组中所有元素的和与平均值。

using System;
using System.Security;
public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("请输入 5 个整数：");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        Console.WriteLine($"数组中所有元素的和为：{sum}");
        Console.WriteLine($"数组中所有元素的平均值为：{sum / (double)arr.Length, 2}");
    }
}