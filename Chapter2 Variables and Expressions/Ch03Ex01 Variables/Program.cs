using System;

namespace Ch03Ex01_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;//声明整型变量
            string myString;//声明字符串
            myInteger = 17;//赋值
            myString = "\"myInteger\" is";//赋值，转义字符
            Console.WriteLine("{0} {1}.",myString,myInteger );//输出
            Console.ReadKey();//暂停代码执行，等待用户按下一个键
        }
    }
}