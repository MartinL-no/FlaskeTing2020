using Microsoft.VisualBasic;
using NUnit.Framework;

namespace FlaskeTing.UnitTest
{
    class OperationSetTest
    {
        [Test]
        public void TestInitial()
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
        public void TestNext()
        {
            var simulation = new Simulation(1, 2, 3);
            var operationSet = new OperationSet(3, simulation);
            var success = operationSet.Next();
            var description = operationSet.GetDescription();
            var expected = "1: Fylle flaske 1 fra springen\n"
                           + "2: Fylle flaske 1 fra springen\n"
                           + "3: Fylle flaske 2 fra springen\n";

            Assert.AreEqual(expected, description);
            Assert.IsTrue(success);
        }

        [Test]
        public void TestNext2()
        {
            var simulation = new Simulation(1, 2, 3);
            var operationSet = new OperationSet(3, simulation);
            for (var i = 0; i < 8; i++) operationSet.Next();
            var description = operationSet.GetDescription();
            var expected = "1: Fylle flaske 1 fra springen\n"
                           + "2: Fylle flaske 2 fra springen\n"
                           + "3: Fylle flaske 1 fra springen\n";

            Assert.AreEqual(expected, description);
        }

        [Test]
        public void TestNext3()
        {
            var simulation = new Simulation(1, 2, 3);
            var operationSet = new OperationSet(2, simulation);
            var success = true;
            for (var i = 0; i < 64; i++) success = operationSet.Next();
            Assert.IsFalse(success);
        }
    }
}
