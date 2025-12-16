using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть ваш вік: ");
        string input = Console.ReadLine();

        int age = int.Parse(input);

        string category = ClassifyAge(age);

        Console.WriteLine(category);
    }

    static string ClassifyAge(int age)
    {
        if (age < 0 || age > 120)
        {
            return "Нереальний вік";
        }
        else if (age <= 12)
        {
            return "Ви дитина";
        }
        else if (age <= 17)
        {
            return "Підліток";
        }
        else if (age <= 59)
        {
            return "Дорослий";
        }
        else
        {
            return "Пенсіонер";
        }
    }
}
