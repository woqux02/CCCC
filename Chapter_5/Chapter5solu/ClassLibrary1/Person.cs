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
    }
}