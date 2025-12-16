using System;

class Program
{
    static void Main()
    {
        int[] numbers = GenerateRandomArray(10, 1, 100);

        Console.WriteLine("Масив чисел:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        int sum = GetSum(numbers);
        double average = GetAverage(numbers);
        int min = GetMin(numbers);
        int max = GetMax(numbers);

        Console.WriteLine("Сума: " + sum);
        Console.WriteLine("Середнє: " + average);
        Console.WriteLine("Мінімум: " + min);
        Console.WriteLine("Максимум: " + max);
    }

    static int[] GenerateRandomArray(int size, int min, int max)
    {
        int[] arr = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < size; i++)
        {
            arr[i] = rnd.Next(min, max + 1); 
        }

        return arr;
    }

    static int GetSum(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static double GetAverage(int[] numbers)
    {
        int sum = GetSum(numbers);
        double average = (double)sum / numbers.Length;
        return average;
    }

    static int GetMin(int[] numbers)
    {
        int min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        return min;
    }

    static int GetMax(int[] numbers)
    {
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }
}
