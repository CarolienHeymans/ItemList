using System;
using System.Collections.Generic;
using System.IO;
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
            using (StreamReader sr = new StreamReader(@"\Users\Carolien\source\repos\newtonsofttest\Newtonsoft test\food.json"))
            {
                var json = sr.ReadToEnd();
                var itemtest = JsonConvert.DeserializeObject<List<Item>>(json);
                foreach (var item in itemtest)
                {
                    Console.WriteLine("Name : " + item.Name + "\tAmount : " + item.Amount);
                }
            }
           //List<Item> items = new List<Item>();
            /* while (true)
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
                   

                    using (StreamWriter sw = new StreamWriter(@"\Users\Carolien\source\repos\newtonsofttest\Newtonsoft test\food.json"))
                    {
                        var collectionResult = JsonConvert.SerializeObject(listItems);
                    Console.WriteLine(collectionResult);
                        foreach (var item in collectionResult)
                        {
                            sw.WriteLine(item);

                        }
                    }*/
                    /* //serialization of collection
                     string collectionResult = JsonConvert.SerializeObject(listItems);
                     Console.WriteLine(collectionResult);


                 //deserialization of collection

                 List<Item> NewListItems=JsonConvert.DeserializeObject<List<Item>>(collectionResult);
                     foreach (var item in NewListItems)
                     {
                         Console.WriteLine("Name : " + item.Name + "\tAmount : " + item.Amount);
                     }
                }

             }*/
             }
        }
    }

