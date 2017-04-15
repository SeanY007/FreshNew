using System;

namespace BooleanOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示并接收一个整数值
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());//Convert.ToInt32--->类型转换
            //声明两个bool类型变量
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = myInt >= 0 && myInt <= 5;
            Console.WriteLine("Integer less than 10?{0}", isLessThan10);
            Console.WriteLine("Integer between 0 and 5?{0}",isBetween0And5);
            Console.WriteLine("Exactly one of the above is true?{0}",isLessThan10^isBetween0And5);
            Console.ReadKey();
        }
    }
}