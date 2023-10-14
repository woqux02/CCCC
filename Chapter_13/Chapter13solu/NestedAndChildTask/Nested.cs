using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace Monitoring
{
    class Nested
    {
        static void OuterMethod()
        {
            WriteLine("Outer Method run...");
            // 等待内部循环执行完成
            var inner = Task.Factory.StartNew(InnerMethod, TaskCreationOptions.AttachedToParent);
            WriteLine("Finished.");
        }

        static void InnerMethod()
        {
            WriteLine("Inner Method run...");
            Thread.Sleep(2000);
            WriteLine("Finished.");
        }

        static void Main(string[] args)
        {
            var outer = Task.Factory.StartNew(OuterMethod);
            // 等待程序执行完毕
            outer.Wait();
            WriteLine("All finished");
        }
    }
}