using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    internal class JaggedArrayDemo
    {
        static void Main()
        {
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[2];
            a[2] = new int[4];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write("Enter Number: ");
                    a[i][ j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    //Console.WriteLine("a[{0},{1}] : {2}", i, j, a[i][j]);
                    Console.Write("\t" + a[i][j]);

                }
                Console.WriteLine();
            }
        }
    }
}
