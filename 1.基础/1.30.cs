//  定义两个 int 数组 a = {1,2,3,4,5} 和 b = {3,4,5,6,7}，找出两个数组的交集（即共有元素），并输出。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] a = [1, 2, 3, 4, 5];
        int[] b = [3, 4, 5, 6, 7];

        Console.WriteLine("数组 a 的元素：");
        foreach (int num in a)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("数组 b 的元素：");
        foreach (int num in b)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("两个数组的交集：");
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    Console.Write(a[i] + " ");
                    break;
                }
            }
        }
    }
}