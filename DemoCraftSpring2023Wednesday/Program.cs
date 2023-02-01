

namespace DemoCraftSpring2023Wednesday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Engine engine= new Engine();
            engine.Run();   

            //examples of concatenation, composite formatting and interpolation

            //string name = "Anonymous Person";
            //string location = "Chicago";

            //Console.WriteLine("Hello, World!");

            //Console.WriteLine("Hello " + name); //concatenation
            //Console.WriteLine("Hello {0} in {1}", name, location); //composite formatting
            //Console.WriteLine($"Hello {name}"); //interpolation

            //Console.ReadKey();

        }
    }
}