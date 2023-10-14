using System;
using static System.Console;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Monitoring
{
    class Sync
    {
        
        static void MethodA()
        {
            WriteLine("Start A:");
            Thread.Sleep(3000);
            WriteLine("Finish A.");
        }
        static void MethodB()
        {
            WriteLine("Start B:");
            Thread.Sleep(2000);
            WriteLine("Finish B.");
        }

        static void MethodC()
        {
            WriteLine("Start C:");
            Thread.Sleep(1000);
            WriteLine("Finish C.");
        }

        static decimal CallWebService()
        {
            WriteLine("Starting call to web service...");
            Thread.Sleep((new Random()).Next(2000, 4000));
            WriteLine("Finished call to service.");
            return 89.99M;
        }

        static string CallStoredProcedure(decimal amount)
        {
            WriteLine("Starting call to stored procedure...");
            Thread.Sleep((new Random()).Next(2000, 4000));
            WriteLine("Finished call to stored procedure.");
            return $"12 products cost more than {amount:C}.";
        }
       
        static void Main(string[] args)
        {
            /*
            var timer = Stopwatch.StartNew();
            // WriteLine("Running methods synchronously on one thread.");
            // MethodA();
            // MethodB();
            // MethodC();
            // WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");

            WriteLine("Running methods synchronously on multiple thread.");
            Task taskA = new Task(MethodA);
            taskA.Start();
            Task taskB = Task.Factory.StartNew(MethodB);
            Task taskC = Task.Run(new Action(MethodC));

            // 他们同时执行，但等所有都执行完程序才继续，也就是取运行时间最长的时间为执行时间
            Task[] tasks = { taskA, taskB, taskC };
            Task.WaitAll(tasks);

            WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
            */

            WriteLine("Passing the result of one task as an input into another");
            var CallAndStored = Task.Factory.StartNew(CallWebService).ContinueWith(previouseTask => CallStoredProcedure(previouseTask.Result));
            WriteLine($"result: {CallAndStored.Result}");
        }
    }
}