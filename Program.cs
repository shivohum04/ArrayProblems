using System;

namespace Q2 // Print unique elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 1, 5, 6 , 1,2, 3};

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
