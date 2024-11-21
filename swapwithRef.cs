using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    internal class swapwithRef
    {
        static void change(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before before...");
            Console.WriteLine("a :{0}", a);
            Console.WriteLine("b :{0}", b);
            //change(a, b); //call by value for both a and b
            change(ref a, ref b); // call by ref for both a and b.
            Console.WriteLine("After swap...");
            Console.WriteLine("a :{0}", a);
            Console.WriteLine("b :{0}", b);
        }
    }
}
