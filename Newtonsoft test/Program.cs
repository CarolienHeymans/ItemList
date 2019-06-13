using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Newtonsoft_test
{
    public class Item
    {

        public string Name { get; set; }

    }
    public class Program
    {
        public static void Main()
        {
        List<Item> items = new List<Item>();
            while (true)
            {
                Console.WriteLine("Add an item or press q to exit");
                
                string answer = Console.ReadLine();
                  if (answer == "q") {
                    break;
                }

                items.Add(new Item { Name = answer });
                foreach (var item in items)
                {
                    Console.WriteLine(" Name {0}", item.Name);
                }
              
            }

        }
    }
          
}