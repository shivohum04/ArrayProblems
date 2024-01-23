using System;
// max and min 
class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 7, 3, 9 };

        int max = numbers[0];
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine("Maximum value: " + max);
        Console.WriteLine("Minimum value: " + min);
    }
}
