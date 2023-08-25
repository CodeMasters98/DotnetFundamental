class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** For Loop in C# ******");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("****** ************** ******");


        Console.WriteLine("****** While Loop in C# ******");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine(j);
            j++;
        }
        Console.WriteLine("****** ************** *******");

        Console.WriteLine("****** Break For Loop in C# ******");
        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine(i);
        }
        Console.WriteLine("****** ******************* *******");
    }   
}
