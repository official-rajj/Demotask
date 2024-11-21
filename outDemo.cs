using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    internal class outDemo
    {
        static void change(out int a, out int b)
        {
            a = 100;
            b = 200;
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before Change...");
            Console.WriteLine("a :{0}", a);
            Console.WriteLine("b :{0}", b);
            //change(a, b); //call by value for both a and b
            change(out a,out b); // call by ref for both a and b.
            Console.WriteLine("After Change...");
            Console.WriteLine("a :{0}", a);
            Console.WriteLine("b :{0}", b);
        }
    }
}
