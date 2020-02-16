using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDC
{
    // Program to get the greatest common divisor GDC
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int count = numbers.Length;

            Console.WriteLine(findGDC(count, numbers));
            Console.ReadLine();

        }

        static int getGDC(int num1, int num2)
        {
            if (num1 == 0) return num2;

            return getGDC((num1 % num2), num2);
        }

        static int findGDC(int count, int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < count; i++)
            {
                result = getGDC(numbers[i], result);
                if (result == 1)
                    return 1;
            }
            return result;
        }
    }
}
