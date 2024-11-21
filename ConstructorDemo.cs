using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    class Order
    {
        int x;
        public Order()
        { }
        public Order(int x)
        {
            this.x = x;
        }
    }
    internal class ConstructorDemo
    {
        static void Main()
        {
            Order obj = new Order(); 
        }
    }
}
