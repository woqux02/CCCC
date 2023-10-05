using System;
using System.Runtime.CompilerServices;
using Packt.Shared;
using static System.Console;

namespace Chapter6
{
    public class Program
    {
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }

        public static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // 调用实例方法
            var baby1 = mary.SonWith(harry);
            baby1.Name = "Gary";

            // 调用静态方法
            var baby2 = Person.Sons(jill, mary);

            WriteLine($"{harry.Name} and {mary.Name} have a son {baby1.Name}");
            WriteLine($"{jill.Name} and {mary.Name} have a son {baby2.Name}");
            WriteLine($"mary has {mary.Children.Count} son");

            // 调用运算符（已经被重载）
            var baby3 = harry * mary;
            WriteLine($"{harry.Name} has {harry.Children.Count} sons.");

            // 调用 Harry_Shout 方法，不知道为什么报错，但是可以执行
            harry.Shout = Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
        }


    }
}
