using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Robert A", "Mike B", "Jeremy C" };
            //for循环遍历
            //int i;
            //Console.WriteLine("Here are {0} of my friends:", friendNames.Length);//获取数组大小
            //for (i = 0; i < friendNames.Length; i++)
            //{
            //    Console.WriteLine(friendNames[i]);
            //}
            //Console.ReadKey();

            //foreach循环
            //Console.WriteLine("Here are {0} of my friends:", friendNames.Length);
            //foreach (string friendName in friendNames)
            //{
            //    Console.WriteLine(friendName); ;
            //}
            //Console.ReadKey();

            string myString = "This is a test.";
            char[] seperator = { ' ' };
            string[] myWords;
            myWords = myString.Split(seperator);
            foreach(string word in myWords){
                Console.WriteLine("{0}",word);
            }
            Console.ReadKey();
        }
    }
}