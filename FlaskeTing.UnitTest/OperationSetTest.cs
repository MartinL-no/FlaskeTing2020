using NUnit.Framework;

namespace FlaskeTing.UnitTest
{
    class OperationSetTest
    {
        [Test]
        public void Test1()
        {
            var simulation = new Simulation(1, 2, 3);
            var operationSet = new OperationSet(3, simulation);
            var description = operationSet.GetDescription();
            var expected = "1: Fylle flaske 1 fra springen\n"
                           + "2: Fylle flaske 1 fra springen\n"
                           + "3: Fylle flaske 1 fra springen\n";

            Assert.AreEqual(expected, description);
        }

        [Test]
        public void Test2()
        {
            var simulation = new Simulation(1,2,3);
            var operationSet = new OperationSet(3, simulation);
            var success = operationSet.Next();
            var description = operationSet.GetDescription();
            var expected = "1: Fylle flaske 1 fra springen\n"
                           + "2: Fylle flaske 1 fra springen\n"
                           + "3: Fylle flaske 2 fra springen\n";

            Assert.AreEqual(expected, description);
            Assert.IsTrue(success);
            // [0, 0, 0] 
            // [0, 0, 1] 
        }
    }
}
