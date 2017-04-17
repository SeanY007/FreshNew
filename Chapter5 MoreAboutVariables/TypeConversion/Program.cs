using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            ////checked/unchecked用法
            //byte destinationVar;
            ////short sourceVar = 7;
            //short sourceVar = 281;//溢出，源数据最左一位丢失 281----->100011001----->000011001---->25
            //destinationVar = (checked((byte)sourceVar));//显示转换 checked进行溢出检查
            //Console.WriteLine("sourceVar val:{0}",sourceVar);
            //Console.WriteLine("destination val:{0}",destinationVar);
            //Console.ReadKey();

            //Convert命令
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5f;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;

            Console.WriteLine("Variable Conversion Example\n");
            doubleResult = floatVal * shortVal;
            Console.WriteLine("Implicit,->double:{0}*{1}->{2}", floatVal, shortVal, doubleResult);

            shortResult = (short)floatVal;
            Console.WriteLine("Explicit,->short:{0}->{1}",floatVal,shortVal);

            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            Console.WriteLine("Explicit,->String:\"{0}\"+\"{1}\"->{2}",boolVal,doubleVal,stringResult);

            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine("Mixed,->long:{0}+{1}->{2}",integerVal,stringVal,longResult);
            Console.ReadKey();
        }
    }
}