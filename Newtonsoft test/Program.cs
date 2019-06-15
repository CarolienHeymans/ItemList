using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            List<Item> MyList = new List<Item>();


            using (StreamReader sr = new StreamReader(DesktopPath + "/food.json"))
            {
                var json = sr.ReadToEnd();
                MyList = JsonConvert.DeserializeObject<List<Item>>(json);
                foreach (var item in MyList)
                {
                    Console.WriteLine("Name : " + item.Name + "\tAmount : " + item.Amount);
                }
            }
           
            while (true)
            {
                Console.WriteLine("Add an item or press q to exit");
                Item NewItem = new Item();

                NewItem.Name = Console.ReadLine();
                if (NewItem.Name == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Add amount:");
                    
                    string input = Console.ReadLine();
                    NewItem.Amount = int.Parse(input);
                    MyList.Add(NewItem);

                }


                    using (StreamWriter sw = new StreamWriter(DesktopPath + "/food.json"))

                    {
                        var collectionResult = JsonConvert.SerializeObject(MyList);
                       sw.WriteLine(collectionResult);
                    Console.WriteLine("Saved Succesfully");
                        }
                }
            }
        }
    }
