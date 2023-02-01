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
            Menu();
            Console.ReadKey();
        }

        private void Menu()
        {
            Print("Choose an option from the menu...");
            Print("1) See your inventory");
            Print("2) Trade");
            Print("3) Exit the application");

            switch(Console.ReadLine())
            {
                case "1":
                    //show inventory
                    Print(player.ShowInventory());
                    break;

                case "2":
                    //trade
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

            }

            Menu();

        }

        //example method returning an instance
        public Product Craft(Recipe recipe)
        {

            return new Product();
        }

    }
}
