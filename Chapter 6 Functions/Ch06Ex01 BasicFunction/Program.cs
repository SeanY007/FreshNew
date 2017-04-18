using System;

namespace Ch06Ex01_BasicFunction
{
    class Program
    {
        static void Write()//函数名一般采用PascalCase形式编写
        {
            Console.WriteLine("Text output from function.");
        }
        static void Main(string[] args)
        {
            Write();
            Console.ReadKey();
        }
    }
}