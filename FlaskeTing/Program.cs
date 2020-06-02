using System;

namespace FlaskeTing
{
    class Program
    {
        static void Main(string[] args)
        {
            var simulation = new Simulation(1, 5, 7);
            var operationSet = simulation.Run();
            Console.WriteLine(operationSet.GetDescription());
        }
    }
}
