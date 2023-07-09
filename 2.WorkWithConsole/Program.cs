using System;

namespace DotnetFundamental
{

    class Program
    {
        static void Main(string[] args)
        {
            //Change some attributes in console
            Console.SetBufferSize(500, 500);//Size of console
            Console.BackgroundColor = ConsoleColor.DarkBlue;//Set Background color
            Console.ForegroundColor = ConsoleColor.DarkRed;//Set Text color
            Console.Title = "My Console!";//Title
            Console.SetCursorPosition(0, 3);//Start of cursor

            Console.Write("Hello!");//To show String in console
            Console.WriteLine("I am Parham Darvishi!");//To show String in console and go to next line
            Console.WriteLine("*********************************************");
            Console.WriteLine("What is your name?");
            Console.ReadLine();//To get string from user
            //Console.ReadKey();

        }
    }


}