using System;

class Program
{
    static void Main()
    {
        Console.Write("vvedit 4islo: ");
        string input = Console.ReadLine();

        int number = int.Parse(input);

        string message = GetMessage(number);

        Console.WriteLine(message);
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static string GetMessage(int number)
    {
        if (IsEven(number))
        {
            return "door are open";
        }
        else
        {
            return "door are close";
        }
    }
}