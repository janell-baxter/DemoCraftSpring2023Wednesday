using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCraftSpring2023Wednesday
{
    public class Engine
    {
        //passing argument to a constructor
        //Player player = new Player("Anonymous Person");

        //object initialization
        Player player = new Player() {Name = "Anonymous Person" };

        public void Run()
        {
            Console.WriteLine($"{player.Name} you have {player.Currency.ToString("c")} currency");
        
            Console.ReadKey();
        }

        public Product Craft (Item item)
        {

            return new Product();
        }

    }
}
