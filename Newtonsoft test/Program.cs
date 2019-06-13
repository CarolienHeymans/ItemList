using System;
using System.Collections.Generic;
using Newtonsoft.Json;

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
                Console.WriteLine("Add an item or press q to exit");

                string answer = Console.ReadLine();
                if (answer == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Add amount:");
                    string input = Console.ReadLine();
                    int result = int.Parse(input);
                    List<Item> listItems = new List<Item> {
                        new Item { Name = answer, Amount = result}
                };
                    //serialization of collection
                    string collectionResult = JsonConvert.SerializeObject(listItems);
                    Console.WriteLine(collectionResult);
               
                
                //deserialization of collection

                List<Item> NewListItems=JsonConvert.DeserializeObject<List<Item>>(collectionResult);
                    foreach (var item in NewListItems)
                    {
                        Console.WriteLine("Name : " + item.Name + "\tAmount : " + item.Amount);
                    }
                }
               
            }
            }
        }
    }
