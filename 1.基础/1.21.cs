//  声明一个包含 5 个整数的数组，分别用两种方式初始化：①直接赋值；②使用初始化列表。然后遍历输出所有元素。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr2 = { 6, 7, 8, 9, 10 };
        int[] arr3 = [11, 12, 13, 14, 15];

        Console.WriteLine("数组 arr1 的元素：");
        foreach (int i in arr1)
        {
            Console.Write(i);
        }
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("数组 arr2 的元素：");
        foreach (int i in arr2)
        {
            Console.Write(i);
        }
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("数组 arr3 的元素：");
        foreach (int i in arr3)
        {
            Console.Write(i);
        }
    }
}