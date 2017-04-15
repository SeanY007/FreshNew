using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToInt32(Console.ReadLine());
            if (var1 < var2)
            {
                comparison = "less than";
            }
            else
            {
                if (var2 == var1)
                {
                    comparison = "equal to";
                }
            else
                {
                    comparison = "greater than";
                }
            }
            Console.WriteLine("The first number is {0} the second number.",comparison);
            Console.ReadKey();
        }
    }
}