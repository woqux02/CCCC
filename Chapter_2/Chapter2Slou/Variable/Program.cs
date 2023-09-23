//变量
using System;

namespace Basic2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("int a : {0}", arg0:a);
            //float、double可以用来计算，但结果不准确，绝对不能用来比较。
            float b = 2.4f;
            Console.WriteLine("float b : {0}", arg0: b);
            double c = 3.55;
            Console.WriteLine("double c : {0}", arg0: c);
            decimal d = 5.1m;
            Console.WriteLine("decimal d : {0}", arg0: d);
            char text = 'a';
            Console.WriteLine("char text : {0}", arg0: text);
            string text2 = "HappyDay";
            Console.WriteLine("string text2 : {0}", arg0: text2);
            //纯文本，去除转义
            string url = @"C:\CJA\video\torriel.txt";
            Console.WriteLine("string(use @) url : {0}", arg0: url);
            bool e = true;
            Console.WriteLine("bool e : {0}", arg0: e);
            byte f = 0;
            Console.WriteLine("byte f : {0}", arg0: f);

            //object在涉及类型转换的领域时容易出错
            //dynamic可以类型转换，但在编写时不会智能提示
            object emp = 12;
            Console.WriteLine("object emp : {0}", arg0: emp);
            dynamic emp2 = "NoUse";
            Console.WriteLine("dynamic emp2 : {0}", arg0: emp2);

            //数组
            int[] listOfNumber = new int[3] {1, 34, 454};
            int m;
            Console.WriteLine("This is array:");
            for (m = 0; m < listOfNumber.Length; m++)
            {
                Console.Write(listOfNumber[m]);
            }

            //值类型不能为空，引用类型可以
        }
    }
}