using System;

namespace MethodOverloadingEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Add(1,1,true));
            Console.WriteLine();
            Console.WriteLine(Add(-2,2,true));
            Console.WriteLine();
            Console.WriteLine(Add(2, 3));
            Console.WriteLine();
            Console.WriteLine(Add(0,1,true));
            Console.WriteLine(Add(2.5m, 3.8m));
        }
        public static int Add (int num1, int num2)
        {
            
            return num1 + num2;
        }
        public static decimal Add (decimal dec1, decimal dec2)
        {
            return dec1 + dec2;
        }

        public static string Add (int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum=num1+num2;
                if (sum == 1)
                {
                    response = $"{sum}dollar.";
                }
                else
                {
                    response =$"{sum}dollars.";
                }
            }
            return response;




        }

    }
}
