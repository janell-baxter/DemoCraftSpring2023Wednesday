using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCraftSpring2023Wednesday
{
    public class Player
    {
        //fields
        private string name;
        private double currency = 30.7899866;

        //properties
        public string Name { get => name; set => name = value; }
        public double Currency { get => currency; set => currency = value; }
        public List<Item> Inventory = new List<Item>()
        {
            new Item(){Name = "Water", Amount = 1, Value = 2.5 },
            new Item(){Name = "Flour", Amount = 2, Value = 6.5 },
            new Item(){Name = "Salt", Amount = 4, Value = 1.5 }
        };

        //constructors (2 - overloaded)
        public Player(string _name)
        {
            name = _name;
        }

        public Player()
        {

        }

        public string ShowInventory()
        {
            string output = "Inventory:\n";
            foreach(Item i in Inventory)
            {
                output += $"{i.Amount} of {i.Name}: {i.Value}{Environment.NewLine}";
            }
            return output;
        }
    }
}