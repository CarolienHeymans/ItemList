using System;
using Newtonsoft.Json;


namespace Newtonsoft_test
{
    public class Product
        //make a class that has a name and a price
    {
        public string Name;
               public int Price; 
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        }
     
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("a", 1);

            product1.Name = "Apple";
          
            product1.Price = 2;

            Product product2 = new Product("a", 1);
            product2.Name = "Pear";

            product2.Price = 3;
                       
            string output1 = JsonConvert.SerializeObject(product1);
            string output2 = JsonConvert.SerializeObject(product2);

            Console.WriteLine(output1);
            Console.WriteLine(output2);

        }
    }
}
