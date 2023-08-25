namespace DotnetFundamental
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Number:");
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }

}