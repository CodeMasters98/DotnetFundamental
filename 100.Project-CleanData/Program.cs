using System;

namespace DotnetFundamental
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your cellphone:");
            string cellphone = Console.ReadLine();
            if (cellphone.Length == 10)
            {
                cellphone = "0" + cellphone;
                Console.WriteLine("Add 0 if length is not enough!, Result: " + cellphone);
            }
            
            if (cellphone.StartsWith("+98"))
            {
                cellphone = cellphone.Replace("+98", "0");
                Console.WriteLine("Replace +98 with 0 !, Result: " + cellphone);
            }

            
        }
    }


}