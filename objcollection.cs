using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask
{
    internal class objcollection
    {
        public static void Main()
        {
            //creating an object of collection
            ArrayList obj = new ArrayList();
            //adding elements into a collection
            obj.Add("RKU");
            obj.Add(100);
            obj.Add(152.65);
            obj.Add('x');
            obj.Add(true);

            //fetching the no of elements into a collection
            Console.WriteLine("Number of Elements:" + obj.Count);
            obj.Remove("RKU");
            foreach (object str in obj)
                Console.WriteLine(str + " ");
            Console.ReadKey();
        }
    }
}
