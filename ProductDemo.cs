using System;

namespace Demotask
{
    /// <summary>
    /// 
    /// </summary>
    class Product
    {
        
        int ProductID;
        string ProductName;
        int MRP;
        string Makeby;
        int Stock;
        int DiscPer;
        int DiscountedPrice;

        public void GetData()
        {
            Console.Write("Enter Product ID: ");
            ProductID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            ProductName = Console.ReadLine();
            Console.Write("Enter MRP: ");
            MRP = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Make By: ");
            Makeby = Console.ReadLine();
            Console.Write("Enter Stock: ");
            Stock = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Discount Percentage: ");
            DiscPer = Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateDiscPrice()
        {
            DiscountedPrice = MRP - (MRP * DiscPer) / 100;
        }

        public void Display()
        {
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("MRP: " + MRP);
            Console.WriteLine("Make By: " + Makeby);
            Console.WriteLine("Stock: " + Stock);
            Console.WriteLine("Discount Percentage: " + DiscPer + "%");
            Console.WriteLine("Discounted Price: " + DiscountedPrice);
        }

        internal class ProductDemo
        {
            static void Main()
            {
                Product obj1 = new Product();
                obj1.GetData();
                obj1.CalculateDiscPrice();
                obj1.Display();
            }
        }
    }
}
