using System;

namespace DotnetFundamental
{

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber; 
            int secondNumber;

            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("firstNumber is greather");
            }
            else if(firstNumber < secondNumber)
            {
                Console.WriteLine("secondNumber is greather");
            }
            else
            {
                Console.WriteLine("both are Equals");
            }
        }
    }


}