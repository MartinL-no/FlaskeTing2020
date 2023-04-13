using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FlaskeTing.UnitTest
{
    class SimulationTest
    {
        [Test]
        public void Test1()
        {
            var simulation = new Simulation(2, 5, 7);
            var operationSet = simulation.Run();
            operationSet.RunOne();
            Assert.IsTrue(simulation.Bottle1.Content == 2 || simulation.Bottle2.Content == 2);
            Assert.AreEqual(2, operationSet.Length);
            var expectedDescription = "1: Fylle flaske 2 fra springen\n2: Fylle opp flaske 1 med flaske 2\n";
            Assert.AreEqual(expectedDescription, operationSet.GetDescription());
        }

        [Test]
        public void Test2()
        {
            var simulation = new Simulation(5, 5, 7);
            var operationSet = simulation.Run();
            operationSet.RunOne();
            Assert.IsTrue(simulation.Bottle1.Content == 5 || simulation.Bottle2.Content == 5);
            Assert.AreEqual(1, operationSet.Length);
            var expectedDescription = "1: Fylle flaske 1 fra springen\n";
            Assert.AreEqual(expectedDescription, operationSet.GetDescription());
        }

        [Test]
        public void Test3()
        {
            var simulation = new Simulation(1, 5, 7);
            var operationSet = simulation.Run();
            var txt = operationSet.GetDescription();
            operationSet.RunOne();
            Assert.IsTrue(simulation.Bottle1.Content == 1 || simulation.Bottle2.Content == 1);
            //Assert.AreEqual(1, operationSet.Length);
            //var expectedDescription = "1: Fylle flaske 1 fra springen\n";
            //Assert.AreEqual(expectedDescription, operationSet.GetDescription());
        }
    }
}
