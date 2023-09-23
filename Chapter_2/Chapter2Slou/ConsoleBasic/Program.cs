using System;
using static System.Console;

namespace ConsoleBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // 格式化输出
            string fruit1 = "Apple";
            int count1 = 1385;
            string fruit2 = "Banana";
            int count2 = 3885;
            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: fruit1,
                arg1: count1);
            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: fruit2,
                arg1: count2);

            //输入
            WriteLine("请输入你的名字：");
            string name = ReadLine();
            WriteLine($"你好，{name}");

            //读取按键
            WriteLine("请按下按键：");
            ConsoleKeyInfo key = ReadKey();
            WriteLine("Key:{0} Char:{1} Modifiers:{2}",
                arg0:key.Key,
                arg1:key.KeyChar,
                arg2:key.Modifiers);

            WriteLine("------------------------------------------------");
            //控制台参数
            WriteLine($"There are {args.Length} arguments.");
            foreach (string arg in args)
            {
                WriteLine(arg);
            }

        }
    }
}