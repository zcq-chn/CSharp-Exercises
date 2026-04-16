//  随机生成一个 1~100 之间的整数，让用户猜数字，每次猜错提示“大了”或“小了”，直到猜中为止，并输出猜的次数。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Random random = new();
        int GussNumber = random.Next(1, 101);
        int count = 0;
        int input;

        Console.WriteLine("猜一个 1 到 100 之间的整数。");
        do
        {
            Console.Write("请输入你的猜测：");
            input = int.Parse(Console.ReadLine());
            count++;

            if (input < GussNumber)
            {
                Console.WriteLine("太小了！");
            }
            else if (input > GussNumber)
            {
                Console.WriteLine("太大了！");
            }
            else
            {
                Console.WriteLine($"恭喜你，猜对了！你总共猜了 {count} 次。");
            }
        } while (input != GussNumber);
    }
}