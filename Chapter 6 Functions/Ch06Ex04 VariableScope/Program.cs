using System;

namespace Ch06Ex04_VariableScope
{
    class Program
    {
        static string myString;
        static void Main(string[] args)
        {
            string myString = "string defined in Main()";
            Program.myString = "Gloabal string";
            Write();
            Console.WriteLine("Now in Main()");
            Console.WriteLine("Local myString={0}",myString);
            Console.WriteLine("Global myString={0}",Program.myString);
            Console.ReadKey();
        }

        static void Write()
        {
            string myString = "string defined in Write()";
            Console.WriteLine("Now in Write()");
            Console.WriteLine("Local myStriing={0}",myString);
            Console.WriteLine("Global myString={0}",Program.myString);
        }
    }
}