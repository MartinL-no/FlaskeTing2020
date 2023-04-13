using NUnit.Framework;

namespace FlaskeTing.UnitTest
{
    public class Tests
    {
        [Test]
        public void TestFillToTopFromTap()
        {
            var bottle = new Bottle(12);
            bottle.FillToTopFromTap();
            Assert.AreEqual(12,bottle.Content);
            Assert.AreEqual(12,bottle.Capacity);
        }

        [Test]
        public void TestFillToTopFromTapNotEmpty()
        {
            var bottle = new Bottle(12);
            bottle.Fill(3);
            bottle.FillToTopFromTap();
            Assert.AreEqual(12, bottle.Content);
        }

        [Test]
        public void TestFill()
        {
            var bottle = new Bottle(12);
            bottle.Fill(5);
            Assert.AreEqual(5, bottle.Content);
        }

        [Test]
        public void TestFill2()
        {
            var bottle = new Bottle(12);
            bottle.Fill(7);
            bottle.Fill(5);
            Assert.AreEqual(12, bottle.Content);
        }

        [Test]
        public void TestFill3()
        {
            var bottle = new Bottle(12);
            bottle.Fill(7);
            bottle.Fill(7);
            Assert.AreEqual(12, bottle.Content);
        }

        [Test]
        public void TestEmpty()
        {
            var bottle = new Bottle(12);
            bottle.Fill(7);
            bottle.Empty();
            Assert.AreEqual(0, bottle.Content);
        }
    }
}