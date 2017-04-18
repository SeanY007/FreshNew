using System;

namespace Ch06Ex05_Delegate
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);
        //定义一个委托，其返回值类型和参数Multiply()、Divide()相匹配
        //delegate关键字用于指定该定义是用于委托而非函数
        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }

        static void Main(string[] args)
        {
            ProcessDelegate process;//使用新的委托定义一个变量
            Console.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();
            if (input == "M")
            {
                process = new ProcessDelegate(Multiply);

            }
            else
                process = new ProcessDelegate(Divide);
            Console.WriteLine("Result:{0}.",process(param1,param2));
            Console.ReadKey();
        }
    }
}