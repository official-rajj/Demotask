using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    internal class MethodOverloadingDemo
    {
        static double Add(double d, double e)
        {

        return (d + e); 
        }
        static double Add(double d, double e, double f)
        {
            return (d + e + f);
        }
        static int Add(int a, int b)
        {

        //return (a + b);
        return (a * b);
        }
        static int Add(int a, int b, int c)
        {

            //return (a + b + c);
            return (a * b * c);
        }
        static void Main()
        {
            int a = 10,b = 20,c = 30;
            double d = 10, e = 20, f = 30;
            int r1 = Add(a,b);
            int r2 = Add(a,b,c);
            double r3 = Add(d,e);
            double r4 = Add(d, e, f);
            Console.WriteLine("a * b =" + r1);
            Console.WriteLine("a * b * c =" + r2);
            Console.WriteLine("d + e =" + r3);
            Console.WriteLine("d + e + f =" + r4);
        }
    }
}
