using Packt.Shared;
using static System.Console;

namespace Chapter5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 导入类库不需要在同一 namespace 中
            // 创建实例
            var bob = new Person();
            WriteLine($"bob.ToSring = {bob.ToString()}");
            // 类的字段
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine("bob.Name = {0}, bob.DateOfBirth = {1:dddd, d MMMM yyyy}",
                arg0: bob.Name, arg1: bob.DateOfBirth);

            // enum 本质上是数字，因此可以将 int 强制转换为 enum
            bob.LikePlace = WondersOfTheAncientWorld.GreatPyramiadOfGiza;
            WriteLine("Bob`s favorate Place is : {0}", arg: bob.LikePlace);
            bob.LikePlace = (WondersOfTheAncientWorld)2;
            WriteLine("Bob`s favorate Place is : {0}", arg: bob.LikePlace);

            // 这里 Chlidren 是一个 List ，新创建了两个 Person 的实例并将其赋给 Childern
            // 字面上的意思：类的列表，也就是说这个 List 可以装多个实例
            bob.Children.Add(new Person { Name = "Zark" });
            bob.Children.Add(new Person { Name = "Blue" });
            WriteLine($"Bob has {bob.Children.Count} Children, {bob.Children[0].Name} and {bob.Children[1].Name}.");

            // 静态字段是这样的字段，它在每个实例中的值都是固定的
            Person.month = 12;
            bob.salary = 3000;
            var jack = new Person();
            jack.salary = 4000;
            WriteLine("bob`s year salary: {0}", arg: bob.salary * Person.month);
            WriteLine("jack`s year salary: {0}", arg: jack.salary * Person.month);
            
            // 常量永远不变，并且只有在编译后才会赋值，这意味着如果代码改动，但并未编译，则它的值还是之前没改的值
            // 静态字段可以重新赋值，而常量永远不能更改
            WriteLine("bob like {0}", arg: Person.Food);

            // 只读字段需要在实例上调用，类似于静态字段
            WriteLine("jack like {0}", arg: jack.Fruit);

            // 构造函数，赋默认值
            var Max = new Person();
            WriteLine("your name is {0}, and the time is {1}.", 
                arg0: Max.Name, arg1: Max.NowTime);

            // 构造函数
            var Car = new Person("Car", "Banana");
            WriteLine("your name is {0}, and your favorite fruit is {1}.",
                arg0: Car.Name, arg1: Car.Fruit);

            // 默认赋初始值
            var SuGuo = new DefaultVar();
            WriteLine("you buy {0} * {1}, at {2}.",
                arg0: SuGuo.Name, arg1: SuGuo.Number, arg2: SuGuo.BuyTime);
        }
    }
}