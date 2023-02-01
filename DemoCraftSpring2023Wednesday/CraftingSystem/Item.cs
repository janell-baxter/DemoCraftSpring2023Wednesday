using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCraftSpring2023Wednesday
{
    public class Item
    {
        private string name = "An item";
        private double value;
        private double amount;

        public string Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
