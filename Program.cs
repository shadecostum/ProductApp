using ProductApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductClass productClass1 = new ProductClass(1,"akash",1000,50.0);
            Console.WriteLine(productClass1.TotalPrice());
           // Console.WriteLine(productClass1.Calculate());
            ProductClass productClass2 = new ProductClass(2, "Akshay", 600);
            Console.WriteLine(productClass2.TotalPrice());
        }
    }
}
