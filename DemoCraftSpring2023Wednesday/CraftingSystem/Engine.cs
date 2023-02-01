using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static DemoCraftSpring2023Wednesday.Display;
namespace DemoCraftSpring2023Wednesday
{
    public class Engine
    {
        //passing argument to a constructor
        //Player player = new Player("Anonymous Person");

        //object initialization
        Player player = new Player() { Name = "Anonymous Person" };

        public void Run()
        {
            //using ToString("c") to format a number as currency
            Print($"{player.Name} you have {player.Currency.ToString("c")} currency");

            Console.ReadKey();
        }

        //example method returning an instance
        public Product Craft(Recipe recipe)
        {

            return new Product();
        }

    }
}
