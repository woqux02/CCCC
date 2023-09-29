using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld LikePlace;
        public List<Person> Children = new List<Person>();
        public int salary;
        public static int month;
        public const string Food = "Pezza";
        public readonly string Fruit = "Apple";
        public readonly DateTime NowTime;

        // 构造函数，赋默认值
        public Person()
        {
            Name = "Famous";
            NowTime = DateTime.Now;
        }

        // 可以有多个构造函数
        public Person(string initName, string likeFruit)
        {
            Name = initName;
            Fruit = likeFruit;
        }
        
        // 返回值
        public void PrintConsole()
        {
            Console.WriteLine("This is Void Method");
        }

        public string PrintString()
        {
            return "This Method return string.";
        }

        public (string, int) GetFood()
        {
            return ("BlueBarry", 3);
        }

        /*
         * 参数默认用 Item 调用，也可以自定义名称
        public (string FruitName, int FruitNum) GetFood()
        {
            return ("BlueBarry", 3);
        }
        */

        // 可选参数
        public string DoList(
            string dowhat = "Nothing",
            int hour = 1,
            string place = "Home")
        {
            return $"You will do {dowhat} for {hour} hour at {place}.";
        }

        // 传递参数
        public void Calculate(int x, ref int y, out int z)
        {
            z = 65;
            x++;
            y++;
            z++;
        }

        // 属性
        public string havelunch
        {
            get
            {
                return $"{Name} will eat {Food} and {Fruit} at lunch.";
            }
        }
    }
}