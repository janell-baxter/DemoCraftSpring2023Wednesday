using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCraftSpring2023Wednesday
{
    public class Player
    {
        private string name;
        private double currency = 30.7899866;

        public string Name { get => name; set => name = value; }
        public double Currency { get => currency; set => currency = value; }

        public Player(string _name)
        {
            name = _name;
        }

        public Player()
        {

        }
    }
}