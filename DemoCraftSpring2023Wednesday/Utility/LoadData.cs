using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoCraftSpring2023Wednesday
{
    internal class LoadData
    {
        public static string LoadTextFromTextFile(string path)
        {
            if(File.Exists(path))
            {
                return File.ReadAllText(path);
            }

            return "data not found";
        }

        public static List<Item> CreateInventoryItemsFromTextFile(string path)
        {
            List<Item> items = new List<Item>();
            string[] itemNames = File.ReadAllLines(path);
            foreach (string itemName in itemNames)
            {
                items.Add(
                    new Item() 
                { 
                    Name = itemName 
                });
            }

            return items;
        }

    }
}
