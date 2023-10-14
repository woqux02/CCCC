using System;
using System.Linq;
using Monitoring;
using static System.Console;

namespace MonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 计算物理内存和虚拟内存的使用量
            // winMax 运行虚拟内存使用量为0，不知道为什么。

            WriteLine("Start Program, wait...");
            Recorder.Start();

            int[] largeArrayInt = Enumerable.Range(1,10000).ToArray();
            System.Threading.Thread.Sleep(new Random().Next(5, 10) * 1000);
            
            Recorder.Stop();
            */

            // StringBuilder 比 + 快无限倍
            int[] numbers = Enumerable.Range(0, 50000).ToArray();

            WriteLine("using + ");
            Recorder.Start();
            string s = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i] + ",";
            }
            Recorder.Stop();

            WriteLine("using StringBuilder");
            Recorder.Start();
            var builder = new System.Text.StringBuilder();
            for (int i = 0;i < numbers.Length; i++)
            {
                builder.Append(numbers[i]);
                builder.Append(',');
            }
            Recorder.Stop();
        }
    }
}