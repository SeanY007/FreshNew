using System;

namespace Ch06Ex03_ExchanngeData
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine("Summed Values = {0}.",sum);
            Console.ReadKey();
        }

        static int SumVals(params int[] vals)//该函数可以接受任意个数int参数，但不能接受其他类型的参数
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
    }
}