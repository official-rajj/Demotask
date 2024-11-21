using System;

namespace Demotask
{
    internal class ArrayDemo2
    {
        static void Main()
        {
            int[,] a = new int[3, 2];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter Number: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] : {2}", i, j, a[i, j]);
                }
            }
        }
    }
}
