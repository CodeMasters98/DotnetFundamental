using System;

namespace DotnetFundamental
{

    class Program
    {
        static void Main(string[] args)
        {
            int numInt = 500;

            // get type of numInt
            var n = numInt.GetType();

            // Implicit Conversion
            double numDouble = numInt;

            // get type of numDouble
            var n1 = numDouble.GetType();

            // Value before conversion
            Console.WriteLine("numInt value: " + numInt);
            Console.WriteLine("numInt Type: " + n);

            // Value after conversion
            Console.WriteLine("numDouble value: " + numDouble);
            Console.WriteLine("numDouble Type: " + n1);
            Console.WriteLine("*************************************************");

            string numberInString = "22";
            Console.WriteLine("number in string: " + numberInString);
            int number = int.Parse(numberInString);
            var n3 = number.GetType();
            Console.WriteLine("number in int: " + number);
            Console.WriteLine("number in Type: " + n3);

            Console.ReadLine();
        }
    }


}