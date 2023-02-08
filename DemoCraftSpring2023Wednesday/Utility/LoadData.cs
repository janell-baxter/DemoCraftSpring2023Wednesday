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
            for (int i = 0; i < itemNames.Length; i += 2)
            {
                bool success = double.TryParse(itemNames[i + 1], out double amount);
                items.Add(new Item() { Name = itemNames[i], Amount = amount });
            }
            return items;
        }

    }
}
