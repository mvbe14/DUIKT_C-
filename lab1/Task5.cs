using System;

class Program
{
    static void Main()
    {
        int[][] groups = new int[][]
        {
            new int[] { 80, 90, 75, 88, 92, 60, 100, 85, 78, 81 },
            new int[] { 70, 65, 50, 95, 72, 68, 90, 55, 74, 60 },
            new int[] { 100, 98, 95, 96, 94, 97, 100, 90, 92, 99 }
        };

        PrintGroupStatistics(groups);
    }

    static double GetAverage(int[] marks)
    {
        if (marks.Length == 0)
        {
            return 0;
        }

        int sum = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }

        double average = (double)sum / marks.Length;
        return average;
    }

    static int GetMin(int[] marks)
    {
        int min = marks[0];

        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] < min)
            {
                min = marks[i];
            }
        }

        return min;
    }

    static int GetMax(int[] marks)
    {
        int max = marks[0];

        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] > max)
            {
                max = marks[i];
            }
        }

        return max;
    }

    static void PrintGroupStatistics(int[][] groups)
    {
        for (int i = 0; i < groups.Length; i++)
        {
            int[] groupMarks = groups[i];

            double average = GetAverage(groupMarks);
            int min = GetMin(groupMarks);
            int max = GetMax(groupMarks);

            Console.WriteLine(
                "Група " + (i + 1) +
                ": Середній = " + Math.Round(average) +
                ", Мінімальний = " + min +
                ", Максимальний = " + max
            );
        }
    }
}