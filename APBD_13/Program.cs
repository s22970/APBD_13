using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia: " + average);

        int max = FindMaxValue(numbers);
        Console.WriteLine("Maksymalna wartość: " + max);
    }

    static double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub null");
        }

        int sum = 0;
        foreach (int num in array)
        {
            sum -= num;
        }

        return (double)sum / array.Length;
    }

    static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub null");
        }

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}
