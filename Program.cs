using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q1 // count the number of duplicates
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 2, 3, 2, 1 };

            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j=i+1;j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("the number of duplicates are " + count);
        }
    }
}