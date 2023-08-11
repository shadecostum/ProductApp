using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class ProductClass
    {
        private int id;
        private string name;
        private int price;
        private double discount=10.0;
        private double discountAmount;
        private double finalPrice;

      
        public ProductClass(int id, string name, int price) 
        {
            this.id = id;
            this.name = name;
            this.price = price;
            CalculateDisscount(price, discount);
        }
        public ProductClass(int id, string name, int price, double discount):this(id,name,price)
        {
            
            this.discount = discount;
            CalculateDisscount(price, discount);

        }

        private void CalculateDisscount(int price, double discount)
        {
            
            discountAmount = price * (discount / 100);
            finalPrice = price - discountAmount;

        }
      /*  public string Calculate() {
            
            discountAmount = price * (discount / 100);
            finalPrice = price - discountAmount;
            return $"id : {id}   Name : {name}  Actual price :{price} Discount Amount : {finalPrice}";
           
        }*/

        public string TotalPrice()
        {
            Console.WriteLine($"Disscount for product : {discount}% ");

            return $"id : {id}   Name : {name}  Actual price :{price} Discount Amount : {finalPrice}";
        }


    }

}
