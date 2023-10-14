using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;


namespace Monitoring
{
    class Resource
    {
        static Random r  = new Random();
        static string message;

        static void MethodA()
        {
            for (int i = 0; i < 5; i++)
            { 
                Thread.Sleep(r.Next(2000));
                message += "A";
                Write(".");
            }
        }
        static void MethodB()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(r.Next(2000));
                message += "B";
                Write(".");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please wait.");
            Stopwatch watch = Stopwatch.StartNew();
            // 同时执行两个方法
            Task a = Task.Factory.StartNew(MethodA);
            Task b = Task.Factory.StartNew(MethodB);
            Task.WaitAll(new Task[] { a, b });
            WriteLine();
            WriteLine("Result: {0}.", message);
            // 两个方法同时访问变量 message，不推荐这样用
            WriteLine($"{watch.ElapsedMilliseconds:#,##0} elapsed milliseconds.");
        }
    }
}