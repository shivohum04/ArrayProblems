using System;

namespace Q3 // count frequency of each element 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 1, 5, 6 , 1,2, 3};

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        numbers[j] = 0;
                    }
                }

                Console.WriteLine(numbers[i] + ":" + count);
            }
        }
    }
}
