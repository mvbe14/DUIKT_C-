using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть сторону a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть сторону b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введіть сторону c: ");
        double c = double.Parse(Console.ReadLine());

        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
            return;
        }

        double perimeter = GetPerimeter(a, b, c);
        double area = GetArea(a, b, c);
        string type = GetTriangleType(a, b, c);

        Console.WriteLine("Периметр: " + perimeter);
        Console.WriteLine("Площа: " + area);
        Console.WriteLine("Тип трикутника: " + type);
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }

        if (a + b <= c) return false;
        if (a + c <= b) return false;
        if (b + c <= a) return false;

        return true;
    }

    static double GetPerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    static double GetArea(double a, double b, double c)
    {
        double p = GetPerimeter(a, b, c) / 2.0;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }

    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Рівносторонній";
        }

        double max = a;
        double x = b;
        double y = c;

        if (b > max)
        {
            max = b;
            x = a;
            y = c;
        }

        if (c > max)
        {
            max = c;
            x = a;
            y = b;
        }

        double epsilon = 0.0001;
        double left = max * max;
        double right = x * x + y * x;

        if (Math.Abs(left - right) < epsilon)
        {
            return "Прямокутний";
        }

        if (a == b || a == c || b == c)
        {
            return "Рівнобедрений";
        }

        return "Довільний";
    }
}
