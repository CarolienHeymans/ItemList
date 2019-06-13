using System;
using System.Collections.Generic;

namespace Newtonsoft_test
{
    public class Item
    {
        public int Amount { get; set; }
        public string Name { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Item> items = new List<Item>();
            while (true)
            {
                Console.WriteLine("Add an item, press v to view list or press q to exit");

                string answer = Console.ReadLine();
                if (answer == "q")
                {
                    break;
                }

                else if (answer == "v")
                {
                    foreach (var item in items)
                    {
                        Console.WriteLine("-- {0}, {1}", item.Name, item.Amount);
                    }
                }
                else
                {
                    Console.WriteLine("Add amount:");
                    string input = Console.ReadLine();
                    int result = int.Parse(input);

                    items.Add(new Item { Name = answer, Amount = result });
                    Console.WriteLine("{0}, {1}", answer, result);

                }
            }
        }
    }
}