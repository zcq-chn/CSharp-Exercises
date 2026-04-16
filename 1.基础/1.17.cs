//  输出 100 以内所有能被 3 整除但不能被 5 整除的数字，每行输出 5 个。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int count = 0;

        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                Console.Write($"{i,3}");
                count++;

                if (count == 5)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
        }
    }
}