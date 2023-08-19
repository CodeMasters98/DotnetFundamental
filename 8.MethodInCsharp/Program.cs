class Program
{
    static void Main(string[] args)
    {
        ShowMessage();
        ShowDevider();
        ShowCustomMessage("This is message from out!");
        ShowDevider();
        AddNumbers(5, 10);
        ShowDevider();
        int result = AddNumbers(5, 10);
        ShowDevider();
    }

    static void ShowMessage()
    {
        Console.WriteLine("Hi!!!");
    }

    static void ShowDevider()
    {
        Console.WriteLine("***************************************");
    }

    static void ShowCustomMessage(string message)
    {
        Console.WriteLine($"Hi!!! {message}");
    }

    static int AddNumbers(int number1 , int number2)
    {
        int result = number1 + number2;
        return result;
    }
}
