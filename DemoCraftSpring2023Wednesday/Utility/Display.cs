using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCraftSpring2023Wednesday
{ 
    internal class Display
    {
        public static Random randomNumber = new Random();
        public static int GetRandomNumber(int Max)
        {
            //usage int amount = GetRandomNumber(5);
            return randomNumber.Next(Max);
        }

        public static int GetRandomNumber(int Min, int Max) => randomNumber.Next(Min, Max); 
        //int amount = GetRandomNumber(1,6);


        public static void Print(string message) 
        {
            Console.WriteLine(message);
        }  
        public static void Print()
        {

        }
    }
}
