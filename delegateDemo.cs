using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    internal class delegateDemo
    {
        //Declaration
        delegate void MyDelegate(int x, int y);

        static void Add(int x,int y)
        {
            Console.WriteLine(x + y);
        }

        static void Sub(int x,int y)
        {
            Console.WriteLine(x - y);
        }

        static void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Main()
        {
            MyDelegate obj = new MyDelegate(Add);
            obj += new MyDelegate(Sub);
            obj += new MyDelegate(Mul);
            obj += Div;

            obj(20, 10);
            //MyDelegate obj1 = new MyDelegate(Add);
            //MyDelegate obj2 = new MyDelegate(Sub);
            //MyDelegate obj3 = new MyDelegate(Mul);
            //MyDelegate obj4 = new MyDelegate(Div);

            //obj1(20,10);
            //obj2(20, 10);
            //obj3(20, 10);
            //obj4(20, 10);
        }
    }
}
