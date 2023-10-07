using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : IComparable<Person>
    {
        // 有字段 Name，DateOfBirth，Person类的List叫Children
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // 静态方法 （里面 new Person 后为什么用 {} ？）
        public static Person Sons(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}."
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        // 实例方法
        public Person SonWith(Person partner)
        {
            return Sons(this, partner);
        }

        // 重载运算符，这里operator是字段名，不是关键字
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Sons(p1, p2);
        }

        // 一个很普通的方法
        public int NameLength(string s)
        {
            return s.Length;
        }

        // 创建一个委托，这个案例不会
        // delegate int ToMethod(string m);
        // var d = new ToMethod(p1.NameLength);

        // 这是一个事件
        public EventHandler Shout;
        public int AngerLevel;
        public void Poke()
        {
            AngerLevel++;
            if(AngerLevel >= 3)
            {
                if(Shout != null)
                {
                    Shout(this, EventArgs.Empty);
                }
            }
        }
 
        // 实现接口
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
