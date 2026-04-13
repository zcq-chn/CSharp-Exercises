//  声明一个 int 变量表示年龄，一个 string 变量表示姓名，然后使用占位符或字符串拼接在控制台输出：“姓名：张三，年龄：25”。

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int age = 25;
        string name = "张三";
        // 使用占位符
        Console.WriteLine("姓名：{0}，年龄：{1}", name, age);
        // 使用字符串拼接
        Console.WriteLine("姓名：" + name + "，年龄：" + age);
    }
}