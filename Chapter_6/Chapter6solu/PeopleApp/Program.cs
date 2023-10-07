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

            // 接口
            Person[] people =
            {
                new Person { Name="Simon" },
                new Person{ Name="Jenny" },
                new Person{ Name="Adam" },
                new Person{ Name="Richard" }
            };
            WriteLine("List of people: ");
            foreach( var person in people ) 
            {
                WriteLine(person.Name);
            }
            WriteLine("Use IComparale implementation to sort:");
             Array.Sort(people);
            foreach( var person in people )
            {
                WriteLine(person.Name);
            }

            // 调用 struct
            var Vect = new DisplacementVector(10, 20);
            var Vect2 = new DisplacementVector(1, 2);
            var Vect3 = Vect + Vect2;
            WriteLine("  ");
            WriteLine("This is Struct : DisplacementVectorzz(10, 20) + DisplacementVector(1, 2) = ");
            WriteLine($"Vect3.x = {Vect3.x}   Vect3.y = {Vect3.y}");

            // 子类
            WriteLine("  ");
            WriteLine("子类:");
            Employee john = new Employee()
            {
                Name = "Jone",
                DateOfBirth = new DateTime(1990, 10, 6)
            };
            // 隐藏方法
            john.WriteToConsole();

            //
            var EmployeeJason = new Employee() { 
                Name = "Jason",
                DateOfBirth = new DateTime(1999, 4, 9)
            };

            WriteLine("  ");
            Person PersonJason = EmployeeJason;
            WriteLine("Person: " + PersonJason.ToString());
            WriteLine("Employee: " + EmployeeJason.ToString());
            PersonJason.WriteToConsole();
            EmployeeJason.WriteToConsole();

        }


    }
}
