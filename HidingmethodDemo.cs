using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotask2
{
    //Data members from class A:1
    //Total Data members :1
    class A
    {
        protected int x;
    }
    //Data members from class A:1
    //Data members from class B:1
    //Total Data members :2

    class B : A // : - means inheritance
    {
        protected int y;
    }
    //Data members from class A:1
    //Data members from class B:1
    //Data members from class C:1
    //Total Data members :3

    class C : B
    {
        protected int z;
        public void GetData(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Display()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }

    /*
        class Person
    {
        protected int ID;
        protected string Name;
        protected string Address;
        protected string City;
        protected string ContNo;
        protected string Email;
        //protected string Salary;
    }

    class Employee : Person //Person is a parent class and Employee is a child class
    {
        protected string Salary;
    }
    */

    internal class HidingmethodDemo
    {
        static void Main()
        {
            C obj = new C();
            obj.GetData(10, 20, 30);
            obj.Display();
        }
    }
}
