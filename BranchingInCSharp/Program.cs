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

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }


}