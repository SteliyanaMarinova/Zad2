using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chisla: ");
            int[] numbers = new int[20];

            int count = 0;
            int minIndex = 999999999;
            int maxIndex = -999999999;

            for (int i = 0; i < numbers.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                numbers[i] = input;
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] < minIndex)
                {
                    minIndex = i;
                }
                if (numbers[i] > maxIndex)
                {
                    maxIndex = i;
                }
            }

            int emptyCount = numbers.Length - count;

            Console.WriteLine($"Broi prazni elementi: {emptyCount}");
            Console.WriteLine($"Index na min chislo: {minIndex}");
            Console.WriteLine($"Index na max chislo: {maxIndex}");
        }
    }
}
