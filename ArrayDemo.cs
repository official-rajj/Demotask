using System;

namespace Demotask
{
    internal class ArrayDemo
    {
        static void Main()
        {
            int[] a = new int[5];
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array Elements are :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]: {1}", i, a[i]);

                if (a[i] % 2 == 0)
                {
                    sumEven += a[i];
                }
                else
                {
                    sumOdd += a[i];
                }
            }

            Console.WriteLine("Sum of even numbers: " + sumEven);
            Console.WriteLine("Sum of odd numbers: " + sumOdd);
        }
    }
}
