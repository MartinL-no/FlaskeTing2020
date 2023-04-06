using System;

namespace FlaskeTing
{
    class Program
    {
        static void Main(string[] args)
        {
            //var simulation = new Simulation(1, 5, 7);
            //var simulation = new Simulation(3, 9, 4);
            var simulation = new Simulation(4, 6, 8);
            var operationSet = simulation.Run();
            Console.WriteLine(operationSet.GetDescription());
        }
    }
}
