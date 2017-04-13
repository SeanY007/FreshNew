using System;

namespace Ch03Ex02_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;//定义两个数
            string userName;//定义一个字符串
            Console.WriteLine("Enter your name:");//提示用户输入
            userName = Console.ReadLine();//接收用户输入
            Console.WriteLine("Welcome {0}", userName);//打印输入结果
            Console.WriteLine("Now give me your number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());//将string类型转换成double类型
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber + secondNumber);//加法
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.", secondNumber, firstNumber, firstNumber - secondNumber);//减法
            Console.WriteLine("The product of {0} and {1} is {2}.",firstNumber ,secondNumber,firstNumber*secondNumber);//乘法
            Console.WriteLine("The result of dividing {0} by {1} is {2}.",firstNumber,secondNumber,firstNumber/secondNumber);//除法
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.",firstNumber,secondNumber,firstNumber%secondNumber);//取余
            Console.ReadKey();
        }
    }
}