namespace FlaskeTing.Test
{
    public class SimulationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSimulationOne()
        {
            var simulation = new Simulation(1, 5, 7);
            var expectedString =
                "1: Fylle flaske 1 fra springen\n" +
                "2: Tømme flaske 1 i flaske 2\n" +
                "3: Fylle flaske 1 fra springen\n" +
                "4: Fylle opp flaske 2 med flaske 1\n" +
                "5: Tømme flaske 2 (kaste vannet)\n" +
                "6: Tømme flaske 1 i flaske 2\n" +
                "7: Fylle flaske 1 fra springen\n" +
                "8: Fylle opp flaske 2 med flaske 1\n";

            var operationSet = simulation.Run();

            Assert.AreEqual(expectedString,operationSet.GetDescription());
        }
        [Test]
        public void TestSimulationTwo()
        {
            var simulation = new Simulation(3, 9, 4);

            var expectedString =
                "1: Fylle flaske 2 fra springen\n" +
                "2: Tømme flaske 2 i flaske 1\n" +
                "3: Fylle flaske 2 fra springen\n" +
                "4: Tømme flaske 2 i flaske 1\n" +
                "5: Fylle flaske 2 fra springen\n" +
                "6: Fylle opp flaske 1 med flaske 2\n";

            var operationSet = simulation.Run();

            Assert.AreEqual(expectedString,operationSet.GetDescription());
        }
        [Test]
        public void TestSimulationThree()
        {
            var simulation = new Simulation(4, 6, 8);

            var expectedString =
                "1: Fylle flaske 1 fra springen\n" +
                "2: Tømme flaske 1 i flaske 2\n" +
                "3: Fylle flaske 1 fra springen\n" +
                "4: Fylle opp flaske 2 med flaske 1\n";

            var operationSet = simulation.Run();

            Assert.AreEqual(expectedString,operationSet.GetDescription());
        }
    }
}

